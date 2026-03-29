//HintName: G.Models.WebSearchRequestSearchDepth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls search comprehensiveness:<br/>
    /// - `basic`: Returns fewer but highly relevant results<br/>
    /// - `advanced`: Performs a deeper search with more results<br/>
    /// Default Value: basic
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchRequestSearchDepth
    {
        /// <summary>
        /// Performs a deeper search with more results
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced")]
        Advanced,
        /// <summary>
        /// Returns fewer but highly relevant results
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestSearchDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestSearchDepth value)
        {
            return value switch
            {
                WebSearchRequestSearchDepth.Advanced => "advanced",
                WebSearchRequestSearchDepth.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestSearchDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => WebSearchRequestSearchDepth.Advanced,
                "basic" => WebSearchRequestSearchDepth.Basic,
                _ => null,
            };
        }
    }
}