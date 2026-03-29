//HintName: G.Models.WebSearchUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchUnits
    {
        /// <summary>
        /// 
        /// </summary>
        Imperial,
        /// <summary>
        /// 
        /// </summary>
        Metric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchUnitsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchUnits value)
        {
            return value switch
            {
                WebSearchUnits.Imperial => "imperial",
                WebSearchUnits.Metric => "metric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchUnits? ToEnum(string value)
        {
            return value switch
            {
                "imperial" => WebSearchUnits.Imperial,
                "metric" => WebSearchUnits.Metric,
                _ => null,
            };
        }
    }
}