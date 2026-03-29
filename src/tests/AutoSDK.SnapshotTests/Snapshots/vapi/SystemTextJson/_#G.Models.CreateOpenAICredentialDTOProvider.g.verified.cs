//HintName: G.Models.CreateOpenAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOpenAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOpenAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOpenAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateOpenAICredentialDTOProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOpenAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => CreateOpenAICredentialDTOProvider.Openai,
                _ => null,
            };
        }
    }
}