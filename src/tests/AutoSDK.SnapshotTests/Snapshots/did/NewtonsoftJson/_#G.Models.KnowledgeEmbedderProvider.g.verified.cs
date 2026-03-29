//HintName: G.Models.KnowledgeEmbedderProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeEmbedderProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-open-ai")]
        AzureOpenAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open-ai")]
        OpenAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeEmbedderProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeEmbedderProvider value)
        {
            return value switch
            {
                KnowledgeEmbedderProvider.AzureOpenAi => "azure-open-ai",
                KnowledgeEmbedderProvider.OpenAi => "open-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeEmbedderProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure-open-ai" => KnowledgeEmbedderProvider.AzureOpenAi,
                "open-ai" => KnowledgeEmbedderProvider.OpenAi,
                _ => null,
            };
        }
    }
}