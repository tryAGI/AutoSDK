//HintName: G.Models.ProvidersAzureOpenAi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProvidersAzureOpenAi
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
    public static class ProvidersAzureOpenAiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersAzureOpenAi value)
        {
            return value switch
            {
                ProvidersAzureOpenAi.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersAzureOpenAi? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ProvidersAzureOpenAi.AzureOpenai,
                _ => null,
            };
        }
    }
}