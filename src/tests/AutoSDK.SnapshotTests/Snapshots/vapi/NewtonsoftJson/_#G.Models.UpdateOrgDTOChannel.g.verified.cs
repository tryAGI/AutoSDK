//HintName: G.Models.UpdateOrgDTOChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateOrgDTOChannel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="daily")]
        Daily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hcs")]
        Hcs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="intuit")]
        Intuit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weekly")]
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOrgDTOChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOrgDTOChannel value)
        {
            return value switch
            {
                UpdateOrgDTOChannel.Daily => "daily",
                UpdateOrgDTOChannel.Default => "default",
                UpdateOrgDTOChannel.Hcs => "hcs",
                UpdateOrgDTOChannel.Intuit => "intuit",
                UpdateOrgDTOChannel.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOrgDTOChannel? ToEnum(string value)
        {
            return value switch
            {
                "daily" => UpdateOrgDTOChannel.Daily,
                "default" => UpdateOrgDTOChannel.Default,
                "hcs" => UpdateOrgDTOChannel.Hcs,
                "intuit" => UpdateOrgDTOChannel.Intuit,
                "weekly" => UpdateOrgDTOChannel.Weekly,
                _ => null,
            };
        }
    }
}