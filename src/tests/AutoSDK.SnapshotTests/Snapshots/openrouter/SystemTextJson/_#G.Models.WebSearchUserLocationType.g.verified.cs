//HintName: G.Models.WebSearchUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchUserLocationType value)
        {
            return value switch
            {
                WebSearchUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => WebSearchUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}