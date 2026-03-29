//HintName: G.Models.CustomLLMCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomLLMCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomLLMCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMCredentialProvider value)
        {
            return value switch
            {
                CustomLLMCredentialProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => CustomLLMCredentialProvider.CustomLlm,
                _ => null,
            };
        }
    }
}