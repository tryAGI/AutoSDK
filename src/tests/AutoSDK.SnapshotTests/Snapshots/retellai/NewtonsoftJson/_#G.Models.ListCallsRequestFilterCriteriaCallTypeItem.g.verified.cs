//HintName: G.Models.ListCallsRequestFilterCriteriaCallTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCallsRequestFilterCriteriaCallTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_call")]
        PhoneCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_call")]
        WebCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsRequestFilterCriteriaCallTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsRequestFilterCriteriaCallTypeItem value)
        {
            return value switch
            {
                ListCallsRequestFilterCriteriaCallTypeItem.PhoneCall => "phone_call",
                ListCallsRequestFilterCriteriaCallTypeItem.WebCall => "web_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsRequestFilterCriteriaCallTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "phone_call" => ListCallsRequestFilterCriteriaCallTypeItem.PhoneCall,
                "web_call" => ListCallsRequestFilterCriteriaCallTypeItem.WebCall,
                _ => null,
            };
        }
    }
}