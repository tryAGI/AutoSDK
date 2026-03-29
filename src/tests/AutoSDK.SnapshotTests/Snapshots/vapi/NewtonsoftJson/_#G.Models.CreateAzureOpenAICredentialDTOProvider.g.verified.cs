//HintName: G.Models.CreateAzureOpenAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAzureOpenAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAzureOpenAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAzureOpenAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateAzureOpenAICredentialDTOProvider.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAzureOpenAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateAzureOpenAICredentialDTOProvider.AzureOpenai,
                _ => null,
            };
        }
    }
}