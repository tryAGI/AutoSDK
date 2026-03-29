//HintName: G.Models.CreateInflectionAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the api key for Pi in InflectionAI's console. Get it from here: https://developers.inflection.ai/keys, billing will need to be setup
    /// </summary>
    public enum CreateInflectionAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInflectionAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInflectionAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateInflectionAICredentialDTOProvider.InflectionAi => "inflection-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInflectionAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "inflection-ai" => CreateInflectionAICredentialDTOProvider.InflectionAi,
                _ => null,
            };
        }
    }
}