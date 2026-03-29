//HintName: G.Models.OrgChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
    /// </summary>
    public enum OrgChannel
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Hcs,
        /// <summary>
        /// 
        /// </summary>
        Intuit,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgChannel value)
        {
            return value switch
            {
                OrgChannel.Daily => "daily",
                OrgChannel.Default => "default",
                OrgChannel.Hcs => "hcs",
                OrgChannel.Intuit => "intuit",
                OrgChannel.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgChannel? ToEnum(string value)
        {
            return value switch
            {
                "daily" => OrgChannel.Daily,
                "default" => OrgChannel.Default,
                "hcs" => OrgChannel.Hcs,
                "intuit" => OrgChannel.Intuit,
                "weekly" => OrgChannel.Weekly,
                _ => null,
            };
        }
    }
}