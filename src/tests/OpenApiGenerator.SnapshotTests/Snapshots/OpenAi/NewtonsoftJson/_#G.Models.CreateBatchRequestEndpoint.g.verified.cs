//HintName: G.Models.CreateBatchRequestEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint to be used for all requests in the batch. Currently `/v1/chat/completions` and `/v1/embeddings` are supported.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateBatchRequestEndpoint
    {
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
    }
}