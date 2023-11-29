internal static class IntExtensions
{
    public static Bits ToBits(this int value)
    {
        return new Bits((byte)value);
    }
}
