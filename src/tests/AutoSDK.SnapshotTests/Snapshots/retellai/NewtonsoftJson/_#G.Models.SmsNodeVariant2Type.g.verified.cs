//HintName: G.Models.SmsNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sms")]
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsNodeVariant2Type value)
        {
            return value switch
            {
                SmsNodeVariant2Type.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "sms" => SmsNodeVariant2Type.Sms,
                _ => null,
            };
        }
    }
}