//HintName: G.Models.DeleteResponseVariant1LlmOpenAIProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum DeleteResponseVariant1LlmOpenAIProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteResponseVariant1LlmOpenAIProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmOpenAIProvider value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmOpenAIProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmOpenAIProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => DeleteResponseVariant1LlmOpenAIProvider.Openai,
                _ => null,
            };
        }
    }
}