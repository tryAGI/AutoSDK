//HintName: G.Models.UpdateSecretRequestVariant2Variant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for Azure OpenAI
    /// </summary>
    public enum UpdateSecretRequestVariant2Variant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalAzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretRequestVariant2Variant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretRequestVariant2Variant2Provider value)
        {
            return value switch
            {
                UpdateSecretRequestVariant2Variant2Provider.ExternalAzureOpenai => "external-azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretRequestVariant2Variant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "external-azure-openai" => UpdateSecretRequestVariant2Variant2Provider.ExternalAzureOpenai,
                _ => null,
            };
        }
    }
}