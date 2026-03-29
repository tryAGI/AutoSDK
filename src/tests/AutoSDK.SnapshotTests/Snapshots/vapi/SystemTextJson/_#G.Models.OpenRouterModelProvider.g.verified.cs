//HintName: G.Models.OpenRouterModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenRouterModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterModelProvider value)
        {
            return value switch
            {
                OpenRouterModelProvider.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => OpenRouterModelProvider.Openrouter,
                _ => null,
            };
        }
    }
}