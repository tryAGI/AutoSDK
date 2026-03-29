//HintName: G.Models.GetAnalyticsGroupsMetadataResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGroupsMetadataResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsMetadataResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsMetadataResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsMetadataResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsMetadataResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetAnalyticsGroupsMetadataResponseObject.List,
                _ => null,
            };
        }
    }
}