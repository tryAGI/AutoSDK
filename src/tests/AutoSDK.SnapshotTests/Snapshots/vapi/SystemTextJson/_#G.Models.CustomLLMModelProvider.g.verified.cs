//HintName: G.Models.CustomLLMModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider that will be used for the model. Any service, including your own server, that is compatible with the OpenAI API can be used.
    /// </summary>
    public enum CustomLLMModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMModelProvider value)
        {
            return value switch
            {
                CustomLLMModelProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => CustomLLMModelProvider.CustomLlm,
                _ => null,
            };
        }
    }
}