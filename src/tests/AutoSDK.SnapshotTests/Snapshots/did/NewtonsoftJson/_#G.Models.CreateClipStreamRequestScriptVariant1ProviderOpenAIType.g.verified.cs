//HintName: G.Models.CreateClipStreamRequestScriptVariant1ProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipStreamRequestScriptVariant1ProviderOpenAIType
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
    public static class CreateClipStreamRequestScriptVariant1ProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestScriptVariant1ProviderOpenAIType value)
        {
            return value switch
            {
                CreateClipStreamRequestScriptVariant1ProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestScriptVariant1ProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateClipStreamRequestScriptVariant1ProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}