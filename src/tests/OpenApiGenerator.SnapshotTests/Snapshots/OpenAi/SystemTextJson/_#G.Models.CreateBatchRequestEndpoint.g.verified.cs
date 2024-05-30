//HintName: G.Models.CreateBatchRequestEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` and `/v1/embeddings` are supported.
    /// </summary>
    public enum CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        V1Embeddings,
    }

    public static class CreateBatchRequestEndpointExtensions
    {
        public static string ToValueString(this CreateBatchRequestEndpoint value)
        {
            return value switch
            {
                CreateBatchRequestEndpoint.V1ChatCompletions => "/v1/chat/completions",
                CreateBatchRequestEndpoint.V1Embeddings => "/v1/embeddings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateBatchRequestEndpoint ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => CreateBatchRequestEndpoint.V1ChatCompletions,
                "/v1/embeddings" => CreateBatchRequestEndpoint.V1Embeddings,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateBatchRequestEndpoint ToEnum(int value)
        {
            return value switch
            {
                0 => CreateBatchRequestEndpoint.V1ChatCompletions,
                1 => CreateBatchRequestEndpoint.V1Embeddings,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}