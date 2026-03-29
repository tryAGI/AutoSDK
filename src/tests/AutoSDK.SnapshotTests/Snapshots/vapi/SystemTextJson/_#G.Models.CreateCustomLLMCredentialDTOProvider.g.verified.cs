//HintName: G.Models.CreateCustomLLMCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCustomLLMCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCustomLLMCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomLLMCredentialDTOProvider value)
        {
            return value switch
            {
                CreateCustomLLMCredentialDTOProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomLLMCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => CreateCustomLLMCredentialDTOProvider.CustomLlm,
                _ => null,
            };
        }
    }
}