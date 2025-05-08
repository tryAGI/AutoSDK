//HintName: G.Models.WebSearchPreviewToolSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchPreviewToolSearchContextSize
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
    public static class WebSearchPreviewToolSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchPreviewToolSearchContextSize value)
        {
            return value switch
            {
                WebSearchPreviewToolSearchContextSize.Low => "low",
                WebSearchPreviewToolSearchContextSize.Medium => "medium",
                WebSearchPreviewToolSearchContextSize.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchPreviewToolSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "low" => WebSearchPreviewToolSearchContextSize.Low,
                "medium" => WebSearchPreviewToolSearchContextSize.Medium,
                "high" => WebSearchPreviewToolSearchContextSize.High,
                _ => null,
            };
        }
    }
}