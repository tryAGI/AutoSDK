//HintName: G.Models.CreateBatchRequestEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` and `/v1/embeddings` are supported.
    /// </summary>
    public abstract class CreateBatchRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        public const string V1ChatCompletions = "/v1/chat/completions";
        /// <summary>
        /// 
        /// </summary>
        public const string V1Embeddings = "/v1/embeddings";
    }
}