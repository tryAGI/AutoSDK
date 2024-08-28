//HintName: G.Models.SummarizeRequestExtractiveness.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.<br/>
    /// Default Value: low
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SummarizeRequestExtractiveness
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeRequestExtractivenessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeRequestExtractiveness value)
        {
            return value switch
            {
                SummarizeRequestExtractiveness.Low => "low",
                SummarizeRequestExtractiveness.Medium => "medium",
                SummarizeRequestExtractiveness.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeRequestExtractiveness? ToEnum(string value)
        {
            return value switch
            {
                "low" => SummarizeRequestExtractiveness.Low,
                "medium" => SummarizeRequestExtractiveness.Medium,
                "high" => SummarizeRequestExtractiveness.High,
                _ => null,
            };
        }
    }
}