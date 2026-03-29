//HintName: G.Models.OpenRouterCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenRouterCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterCredentialProvider value)
        {
            return value switch
            {
                OpenRouterCredentialProvider.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => OpenRouterCredentialProvider.Openrouter,
                _ => null,
            };
        }
    }
}