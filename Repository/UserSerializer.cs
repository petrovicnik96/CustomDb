using Custom_Database.Core.Helpers;

namespace Custom_Database.Repository;

/// <summary>
/// This class serializes a UserModel into byte[] for using with RecordStorage
/// As long as it is XML, JSON, Protobuf or Binary serialization.
/// </summary>
class UserSerializer
{
    public byte[] Serialize(UserModel user)
    {
        var nameBytes = System.Text.Encoding.UTF8.GetBytes(user.FullName);
        var bloodTypeBytes = System.Text.Encoding.UTF8.GetBytes(user.BloodType);
        var userData = new byte[
            16 +                // 16 Bytes for Guid id
            4 +                 // 4 Bytes indicate the length of 'fullname' sting
            nameBytes.Length +  // n Bytes for name string
            4 +                 // 4 Bytes for age
            4 +                 // 4 Bytes for blood type
            bloodTypeBytes.Length + 
            4 +                 // 4 Bytes indicate length of DNA data
            user.DnaData.Length
        ];
        
        Buffer.BlockCopy(
            src: user.Id.ToByteArray(),
            srcOffset: 0,
            dst: userData,
            dstOffset: 0,
            count: 15 
        );

        Buffer.BlockCopy(
            src: LittleEndianByteOrder.GetBytes<int>(nameBytes.Length),
            srcOffset: 0,
            dst: userData,
            dstOffset: 16 + 4,
            count: 4
        );

        return userData;
    }

}
