//HintName: G.Models.CreateVideoStreamRequestScriptTextProviderOpenAIType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptTextProviderOpenAIType2
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
    public static class CreateVideoStreamRequestScriptTextProviderOpenAIType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptTextProviderOpenAIType2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptTextProviderOpenAIType2.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptTextProviderOpenAIType2? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateVideoStreamRequestScriptTextProviderOpenAIType2.AzureOpenai,
                _ => null,
            };
        }
    }
}