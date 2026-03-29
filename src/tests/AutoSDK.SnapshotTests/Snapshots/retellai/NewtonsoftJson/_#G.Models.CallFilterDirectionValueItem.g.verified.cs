//HintName: G.Models.CallFilterDirectionValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallFilterDirectionValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inbound")]
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outbound")]
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallFilterDirectionValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallFilterDirectionValueItem value)
        {
            return value switch
            {
                CallFilterDirectionValueItem.Inbound => "inbound",
                CallFilterDirectionValueItem.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallFilterDirectionValueItem? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => CallFilterDirectionValueItem.Inbound,
                "outbound" => CallFilterDirectionValueItem.Outbound,
                _ => null,
            };
        }
    }
}