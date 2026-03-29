//HintName: G.Models.CreateXAiCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the api key for Grok in XAi's console. Get it from here: https://console.x.ai
    /// </summary>
    public enum CreateXAiCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateXAiCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateXAiCredentialDTOProvider value)
        {
            return value switch
            {
                CreateXAiCredentialDTOProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateXAiCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => CreateXAiCredentialDTOProvider.Xai,
                _ => null,
            };
        }
    }
}