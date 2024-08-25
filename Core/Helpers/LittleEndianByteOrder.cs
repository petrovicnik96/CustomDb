namespace Custom_Database.Core.Helpers;

internal class LittleEndianByteOrder
{
    public static byte[] GetBytes<T> (T value) where T : struct
    {
        byte[] bytes = value switch
        {
            int intValue => BitConverter.GetBytes(intValue),
            long longValue => BitConverter.GetBytes(longValue),
            uint uintValue => BitConverter.GetBytes(uintValue),
            float floatValue => BitConverter.GetBytes(floatValue),
            double doubleValue => BitConverter.GetBytes(doubleValue),
            _ => throw new ArgumentException("Unsupported type."),
        };
        if (!BitConverter.IsLittleEndian) Array.Reverse(bytes);

        return bytes;
    }
}
