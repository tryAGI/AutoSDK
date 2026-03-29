//HintName: G.Models.SmsDestinationVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsDestinationVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsDestinationVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsDestinationVariant1Type value)
        {
            return value switch
            {
                SmsDestinationVariant1Type.CustomerNumber => "customer_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsDestinationVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "customer_number" => SmsDestinationVariant1Type.CustomerNumber,
                _ => null,
            };
        }
    }
}