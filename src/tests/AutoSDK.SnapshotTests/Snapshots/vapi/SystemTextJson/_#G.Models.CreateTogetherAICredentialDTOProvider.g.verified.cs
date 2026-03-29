//HintName: G.Models.CreateTogetherAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTogetherAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTogetherAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTogetherAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateTogetherAICredentialDTOProvider.TogetherAi => "together-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTogetherAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "together-ai" => CreateTogetherAICredentialDTOProvider.TogetherAi,
                _ => null,
            };
        }
    }
}