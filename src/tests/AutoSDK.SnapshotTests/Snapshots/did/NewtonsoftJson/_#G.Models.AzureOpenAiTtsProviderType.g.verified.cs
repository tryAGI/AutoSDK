//HintName: G.Models.AzureOpenAiTtsProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureOpenAiTtsProviderType
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
    public static class AzureOpenAiTtsProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAiTtsProviderType value)
        {
            return value switch
            {
                AzureOpenAiTtsProviderType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAiTtsProviderType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AzureOpenAiTtsProviderType.AzureOpenai,
                _ => null,
            };
        }
    }
}