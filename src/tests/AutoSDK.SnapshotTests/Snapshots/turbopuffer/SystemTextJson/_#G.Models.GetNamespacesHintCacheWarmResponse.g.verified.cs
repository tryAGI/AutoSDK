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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "ACCEPTED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetNamespacesHintCacheWarmResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="status">
        /// The status of the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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