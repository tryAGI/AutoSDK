//HintName: G.Models.CreateMistralCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMistralCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mistral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMistralCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMistralCredentialDTOProvider value)
        {
            return value switch
            {
                CreateMistralCredentialDTOProvider.Mistral => "mistral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMistralCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "mistral" => CreateMistralCredentialDTOProvider.Mistral,
                _ => null,
            };
        }
    }
}