//HintName: G.Models.CloudJiraDataSourceV2ApiVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Jira REST API version to use (2 or 3). 3 supports Atlassian Document Format (ADF).<br/>
    /// Default Value: 2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CloudJiraDataSourceV2ApiVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2")]
        x2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="3")]
        x3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloudJiraDataSourceV2ApiVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloudJiraDataSourceV2ApiVersion value)
        {
            return value switch
            {
                CloudJiraDataSourceV2ApiVersion.x2 => "2",
                CloudJiraDataSourceV2ApiVersion.x3 => "3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloudJiraDataSourceV2ApiVersion? ToEnum(string value)
        {
            return value switch
            {
                "2" => CloudJiraDataSourceV2ApiVersion.x2,
                "3" => CloudJiraDataSourceV2ApiVersion.x3,
                _ => null,
            };
        }
    }
}