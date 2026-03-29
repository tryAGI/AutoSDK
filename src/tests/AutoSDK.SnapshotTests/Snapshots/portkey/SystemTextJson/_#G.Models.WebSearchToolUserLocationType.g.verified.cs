//HintName: G.Models.WebSearchToolUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of location approximation. Always `approximate`.
    /// </summary>
    public enum WebSearchToolUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolUserLocationType value)
        {
            return value switch
            {
                WebSearchToolUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => WebSearchToolUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}