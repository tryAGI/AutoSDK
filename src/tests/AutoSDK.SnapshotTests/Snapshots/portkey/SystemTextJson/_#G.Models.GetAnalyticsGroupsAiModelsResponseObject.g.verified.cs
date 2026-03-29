//HintName: G.Models.GetAnalyticsGroupsAiModelsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAnalyticsGroupsAiModelsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGroupsAiModelsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGroupsAiModelsResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGroupsAiModelsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGroupsAiModelsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GetAnalyticsGroupsAiModelsResponseObject.List,
                _ => null,
            };
        }
    }
}