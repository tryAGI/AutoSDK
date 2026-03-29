//HintName: G.Models.GetAnalyticsGraphsFeedbacksAiModelsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsGraphsFeedbacksAiModelsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analytics-graph")]
        AnalyticsGraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsGraphsFeedbacksAiModelsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsGraphsFeedbacksAiModelsResponseObject value)
        {
            return value switch
            {
                GetAnalyticsGraphsFeedbacksAiModelsResponseObject.AnalyticsGraph => "analytics-graph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsGraphsFeedbacksAiModelsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-graph" => GetAnalyticsGraphsFeedbacksAiModelsResponseObject.AnalyticsGraph,
                _ => null,
            };
        }
    }
}