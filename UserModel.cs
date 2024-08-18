namespace Custom_Database;

public class UserModel
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string BloodType { get; set; }
    public byte[] DnaData { get; set; }

}
