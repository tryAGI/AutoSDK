//HintName: G.Models.SmsSenderVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsSenderVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ShortCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSenderVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSenderVariant2Type value)
        {
            return value switch
            {
                SmsSenderVariant2Type.ShortCode => "short_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSenderVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "short_code" => SmsSenderVariant2Type.ShortCode,
                _ => null,
            };
        }
    }
}