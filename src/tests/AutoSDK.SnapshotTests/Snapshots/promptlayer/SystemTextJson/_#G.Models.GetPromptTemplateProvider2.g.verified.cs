//HintName: G.Models.GetPromptTemplateProvider2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPromptTemplateProvider2
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
    public static class GetPromptTemplateProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptTemplateProvider2 value)
        {
            return value switch
            {
                GetPromptTemplateProvider2.Anthropic => "anthropic",
                GetPromptTemplateProvider2.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptTemplateProvider2? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => GetPromptTemplateProvider2.Anthropic,
                "openai" => GetPromptTemplateProvider2.Openai,
                _ => null,
            };
        }
    }
}