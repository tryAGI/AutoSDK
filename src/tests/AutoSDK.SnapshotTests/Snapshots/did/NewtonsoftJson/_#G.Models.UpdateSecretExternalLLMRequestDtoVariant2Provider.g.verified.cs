//HintName: G.Models.UpdateSecretExternalLLMRequestDtoVariant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for Azure OpenAI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretExternalLLMRequestDtoVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-azure-openai")]
        ExternalAzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretExternalLLMRequestDtoVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretExternalLLMRequestDtoVariant2Provider value)
        {
            return value switch
            {
                UpdateSecretExternalLLMRequestDtoVariant2Provider.ExternalAzureOpenai => "external-azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretExternalLLMRequestDtoVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "external-azure-openai" => UpdateSecretExternalLLMRequestDtoVariant2Provider.ExternalAzureOpenai,
                _ => null,
            };
        }
    }
}