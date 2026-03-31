//HintName: G.Models.OpenAILLMCreateDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum OpenAILLMCreateDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAILLMCreateDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAILLMCreateDtoProvider value)
        {
            return value switch
            {
                OpenAILLMCreateDtoProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAILLMCreateDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAILLMCreateDtoProvider.Openai,
                _ => null,
            };
        }
    }
}