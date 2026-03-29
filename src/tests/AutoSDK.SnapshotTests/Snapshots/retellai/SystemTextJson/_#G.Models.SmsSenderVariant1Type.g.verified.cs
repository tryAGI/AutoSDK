//HintName: G.Models.SmsSenderVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsSenderVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        CurrentNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSenderVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSenderVariant1Type value)
        {
            return value switch
            {
                SmsSenderVariant1Type.CurrentNumber => "current_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSenderVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "current_number" => SmsSenderVariant1Type.CurrentNumber,
                _ => null,
            };
        }
    }
}