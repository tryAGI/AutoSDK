//HintName: G.Models.UpdateSecretAzureOpenAIRequestDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for Azure OpenAI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretAzureOpenAIRequestDtoProvider
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
    public static class UpdateSecretAzureOpenAIRequestDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretAzureOpenAIRequestDtoProvider value)
        {
            return value switch
            {
                UpdateSecretAzureOpenAIRequestDtoProvider.ExternalAzureOpenai => "external-azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretAzureOpenAIRequestDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-azure-openai" => UpdateSecretAzureOpenAIRequestDtoProvider.ExternalAzureOpenai,
                _ => null,
            };
        }
    }
}