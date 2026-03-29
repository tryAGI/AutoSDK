//HintName: G.Models.CallFilterCallTypeValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallFilterCallTypeValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        PhoneCall,
        /// <summary>
        /// 
        /// </summary>
        WebCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallFilterCallTypeValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallFilterCallTypeValueItem value)
        {
            return value switch
            {
                CallFilterCallTypeValueItem.PhoneCall => "phone_call",
                CallFilterCallTypeValueItem.WebCall => "web_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallFilterCallTypeValueItem? ToEnum(string value)
        {
            return value switch
            {
                "phone_call" => CallFilterCallTypeValueItem.PhoneCall,
                "web_call" => CallFilterCallTypeValueItem.WebCall,
                _ => null,
            };
        }
    }
}