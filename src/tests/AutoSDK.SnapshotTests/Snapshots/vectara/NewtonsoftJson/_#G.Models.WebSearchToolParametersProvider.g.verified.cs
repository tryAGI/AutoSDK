//HintName: G.Models.WebSearchToolParametersProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search provider to use.<br/>
    /// Example: tavily
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchToolParametersProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tavily")]
        Tavily,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolParametersProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolParametersProvider value)
        {
            return value switch
            {
                WebSearchToolParametersProvider.Tavily => "tavily",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolParametersProvider? ToEnum(string value)
        {
            return value switch
            {
                "tavily" => WebSearchToolParametersProvider.Tavily,
                _ => null,
            };
        }
    }
}