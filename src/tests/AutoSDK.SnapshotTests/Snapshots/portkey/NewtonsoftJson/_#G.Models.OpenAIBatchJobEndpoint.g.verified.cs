//HintName: G.Models.OpenAIBatchJobEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inference endpoint
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIBatchJobEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/chat/completions")]
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/completions")]
        V1Completions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/embeddings")]
        V1Embeddings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIBatchJobEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIBatchJobEndpoint value)
        {
            return value switch
            {
                OpenAIBatchJobEndpoint.V1ChatCompletions => "/v1/chat/completions",
                OpenAIBatchJobEndpoint.V1Completions => "/v1/completions",
                OpenAIBatchJobEndpoint.V1Embeddings => "/v1/embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIBatchJobEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => OpenAIBatchJobEndpoint.V1ChatCompletions,
                "/v1/completions" => OpenAIBatchJobEndpoint.V1Completions,
                "/v1/embeddings" => OpenAIBatchJobEndpoint.V1Embeddings,
                _ => null,
            };
        }
    }
}