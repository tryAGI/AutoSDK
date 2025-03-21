//HintName: G.Models.WebSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// High level guidance for the amount of context window space to use for the <br/>
    /// search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
    /// Default Value: medium
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchContextSize
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
    public static class WebSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchContextSize value)
        {
            return value switch
            {
                WebSearchContextSize.Low => "low",
                WebSearchContextSize.Medium => "medium",
                WebSearchContextSize.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "low" => WebSearchContextSize.Low,
                "medium" => WebSearchContextSize.Medium,
                "high" => WebSearchContextSize.High,
                _ => null,
            };
        }
    }
}