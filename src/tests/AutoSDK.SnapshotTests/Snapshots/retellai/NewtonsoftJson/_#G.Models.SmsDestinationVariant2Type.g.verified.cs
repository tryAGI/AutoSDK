//HintName: G.Models.SmsDestinationVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsDestinationVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_number")]
        PhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsDestinationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsDestinationVariant2Type value)
        {
            return value switch
            {
                SmsDestinationVariant2Type.PhoneNumber => "phone_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsDestinationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "phone_number" => SmsDestinationVariant2Type.PhoneNumber,
                _ => null,
            };
        }
    }
}