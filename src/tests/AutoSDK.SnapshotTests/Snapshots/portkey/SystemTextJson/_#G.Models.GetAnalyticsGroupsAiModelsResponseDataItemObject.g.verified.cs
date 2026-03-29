//HintName: G.Models.GetAnalyticsGroupsAiModelsResponseDataItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    public enum GetAnalyticsGroupsAiModelsResponseDataItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsAiModelsResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsAiModelsResponseDataItemObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsAiModelsResponseDataItemObject.AnalyticsGroup => "analytics-group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsAiModelsResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-group" => GetAnalyticsGroupsAiModelsResponseDataItemObject.AnalyticsGroup,
                _ => null,
            };
        }
    }
}