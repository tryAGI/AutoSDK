//HintName: G.Models.GetAnalyticsGroupsMetadataResponseDataItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGroupsMetadataResponseDataItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analytics-group")]
        AnalyticsGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsMetadataResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsMetadataResponseDataItemObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsMetadataResponseDataItemObject.AnalyticsGroup => "analytics-group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsMetadataResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-group" => GetAnalyticsGroupsMetadataResponseDataItemObject.AnalyticsGroup,
                _ => null,
            };
        }
    }
}