//HintName: G.Models.GetNamespacesHintCacheWarmResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to a successful cache warm request.
    /// </summary>
    public sealed partial class GetNamespacesHintCacheWarmResponse
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <default>"ACCEPTED"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "ACCEPTED";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacesHintCacheWarmResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status">
        /// The status of the request.
        /// </param>
        public GetNamespacesHintCacheWarmResponse(
            string? message,
            string status = "ACCEPTED")
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacesHintCacheWarmResponse" /> class.
        /// </summary>
        public GetNamespacesHintCacheWarmResponse()
        {
        }
    }
}