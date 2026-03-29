//HintName: G.Models.CreateClipRequestScriptVariant1ProviderOpenAIType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipRequestScriptVariant1ProviderOpenAIType2
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
    public static class CreateClipRequestScriptVariant1ProviderOpenAIType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipRequestScriptVariant1ProviderOpenAIType2 value)
        {
            return value switch
            {
                CreateClipRequestScriptVariant1ProviderOpenAIType2.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipRequestScriptVariant1ProviderOpenAIType2? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateClipRequestScriptVariant1ProviderOpenAIType2.AzureOpenai,
                _ => null,
            };
        }
    }
}