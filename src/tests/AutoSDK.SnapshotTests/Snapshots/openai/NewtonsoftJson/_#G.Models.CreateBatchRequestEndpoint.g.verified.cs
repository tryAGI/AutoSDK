//HintName: G.Models.CreateBatchRequestEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/responses`, `/v1/chat/completions`, `/v1/embeddings`, and `/v1/completions` are supported. Note that `/v1/embeddings` batches are also restricted to a maximum of 50,000 embedding inputs across all requests in the batch.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/responses")]
        V1Responses,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/chat/completions")]
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/embeddings")]
        V1Embeddings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/completions")]
        V1Completions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBatchRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBatchRequestEndpoint value)
        {
            return value switch
            {
                CreateBatchRequestEndpoint.V1Responses => "/v1/responses",
                CreateBatchRequestEndpoint.V1ChatCompletions => "/v1/chat/completions",
                CreateBatchRequestEndpoint.V1Embeddings => "/v1/embeddings",
                CreateBatchRequestEndpoint.V1Completions => "/v1/completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBatchRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/responses" => CreateBatchRequestEndpoint.V1Responses,
                "/v1/chat/completions" => CreateBatchRequestEndpoint.V1ChatCompletions,
                "/v1/embeddings" => CreateBatchRequestEndpoint.V1Embeddings,
                "/v1/completions" => CreateBatchRequestEndpoint.V1Completions,
                _ => null,
            };
        }
    }
}