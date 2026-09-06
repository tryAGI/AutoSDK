//HintName: G.Models.GetPromptTemplateProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPromptTemplateProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPromptTemplateProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptTemplateProvider value)
        {
            return value switch
            {
                GetPromptTemplateProvider.Anthropic => "anthropic",
                GetPromptTemplateProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptTemplateProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => GetPromptTemplateProvider.Anthropic,
                "openai" => GetPromptTemplateProvider.Openai,
                _ => null,
            };
        }
    }
}