//HintName: G.Models.StreamTextScriptProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamTextScriptProviderOpenAIType
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
    public static class StreamTextScriptProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTextScriptProviderOpenAIType value)
        {
            return value switch
            {
                StreamTextScriptProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTextScriptProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => StreamTextScriptProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}