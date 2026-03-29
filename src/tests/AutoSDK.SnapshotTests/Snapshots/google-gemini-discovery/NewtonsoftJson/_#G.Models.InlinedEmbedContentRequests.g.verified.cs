//HintName: G.Models.InlinedEmbedContentRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The requests to be processed in the batch if provided as part of the batch creation request.
    /// </summary>
    public sealed partial class InlinedEmbedContentRequests
    {
        /// <summary>
        /// Required. The requests to be processed in the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public global::System.Collections.Generic.IList<global::G.InlinedEmbedContentRequest>? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequests" /> class.
        /// </summary>
        /// <param name="requests">
        /// Required. The requests to be processed in the batch.
        /// </param>
        public InlinedEmbedContentRequests(
            global::System.Collections.Generic.IList<global::G.InlinedEmbedContentRequest>? requests)
        {
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentRequests" /> class.
        /// </summary>
        public InlinedEmbedContentRequests()
        {
        }
    }
}