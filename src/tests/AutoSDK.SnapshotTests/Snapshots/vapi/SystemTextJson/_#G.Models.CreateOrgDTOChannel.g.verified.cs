//HintName: G.Models.CreateOrgDTOChannel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the channel of the org. There is the cluster the API traffic for the org will be directed.
    /// </summary>
    public enum CreateOrgDTOChannel
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
    public static class CreateOrgDTOChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrgDTOChannel value)
        {
            return value switch
            {
                CreateOrgDTOChannel.Daily => "daily",
                CreateOrgDTOChannel.Default => "default",
                CreateOrgDTOChannel.Hcs => "hcs",
                CreateOrgDTOChannel.Intuit => "intuit",
                CreateOrgDTOChannel.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrgDTOChannel? ToEnum(string value)
        {
            return value switch
            {
                "daily" => CreateOrgDTOChannel.Daily,
                "default" => CreateOrgDTOChannel.Default,
                "hcs" => CreateOrgDTOChannel.Hcs,
                "intuit" => CreateOrgDTOChannel.Intuit,
                "weekly" => CreateOrgDTOChannel.Weekly,
                _ => null,
            };
        }
    }
}