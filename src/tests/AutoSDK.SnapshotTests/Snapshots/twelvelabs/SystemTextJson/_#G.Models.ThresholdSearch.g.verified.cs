//HintName: G.Models.ThresholdSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// &lt;Info&gt;<br/>
    ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank)  field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
    /// &lt;/Info&gt;<br/>
    /// Use this parameter to filter on the level of confidence that the results match your query.<br/>
    /// **Default**: `low`<br/>
    /// Default Value: low
    /// </summary>
    public enum ThresholdSearch
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// `low`
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThresholdSearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThresholdSearch value)
        {
            return value switch
            {
                ThresholdSearch.High => "high",
                ThresholdSearch.Low => "low",
                ThresholdSearch.Medium => "medium",
                ThresholdSearch.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThresholdSearch? ToEnum(string value)
        {
            return value switch
            {
                "high" => ThresholdSearch.High,
                "low" => ThresholdSearch.Low,
                "medium" => ThresholdSearch.Medium,
                "none" => ThresholdSearch.None,
                _ => null,
            };
        }
    }
}