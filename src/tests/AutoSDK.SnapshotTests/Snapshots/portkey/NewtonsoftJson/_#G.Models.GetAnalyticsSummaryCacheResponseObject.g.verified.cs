//HintName: G.Models.GetAnalyticsSummaryCacheResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object being returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAnalyticsSummaryCacheResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analytics-summary")]
        AnalyticsSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAnalyticsSummaryCacheResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsSummaryCacheResponseObject value)
        {
            return value switch
            {
                GetAnalyticsSummaryCacheResponseObject.AnalyticsSummary => "analytics-summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsSummaryCacheResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "analytics-summary" => GetAnalyticsSummaryCacheResponseObject.AnalyticsSummary,
                _ => null,
            };
        }
    }
}