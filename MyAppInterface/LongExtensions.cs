internal static class LongExtensions
{
    public static Bits ToBits(this long value)
    {
        return new Bits((byte)value);
    }
}

