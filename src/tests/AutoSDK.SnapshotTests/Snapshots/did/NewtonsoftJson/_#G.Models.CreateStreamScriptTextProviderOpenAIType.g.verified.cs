//HintName: G.Models.CreateStreamScriptTextProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateStreamScriptTextProviderOpenAIType
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
    public static class CreateStreamScriptTextProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamScriptTextProviderOpenAIType value)
        {
            return value switch
            {
                CreateStreamScriptTextProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamScriptTextProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateStreamScriptTextProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}