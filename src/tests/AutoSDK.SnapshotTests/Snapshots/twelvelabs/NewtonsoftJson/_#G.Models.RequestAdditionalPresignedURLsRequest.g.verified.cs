//HintName: G.Models.RequestAdditionalPresignedURLsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestAdditionalPresignedURLsRequest
    {
        /// <summary>
        /// The index of the first chunk number to generate URLs for. Chunks are numbered from 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The number of presigned URLs to generate starting from the index. You can request a maximum of 50 URLs in a single API call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAdditionalPresignedURLsRequest" /> class.
        /// </summary>
        /// <param name="start">
        /// The index of the first chunk number to generate URLs for. Chunks are numbered from 1.
        /// </param>
        /// <param name="count">
        /// The number of presigned URLs to generate starting from the index. You can request a maximum of 50 URLs in a single API call.
        /// </param>
        public RequestAdditionalPresignedURLsRequest(
            int start,
            int count)
        {
            this.Start = start;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestAdditionalPresignedURLsRequest" /> class.
        /// </summary>
        public RequestAdditionalPresignedURLsRequest()
        {
        }
    }
}