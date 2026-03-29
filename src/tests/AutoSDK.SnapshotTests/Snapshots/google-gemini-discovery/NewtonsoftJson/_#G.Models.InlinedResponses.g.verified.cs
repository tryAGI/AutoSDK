//HintName: G.Models.InlinedResponses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The responses to the requests in the batch.
    /// </summary>
    public sealed partial class InlinedResponses
    {
        /// <summary>
        /// Output only. The responses to the requests in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inlinedResponses")]
        public global::System.Collections.Generic.IList<global::G.InlinedResponse>? InlinedResponses1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedResponses" /> class.
        /// </summary>
        /// <param name="inlinedResponses1">
        /// Output only. The responses to the requests in the batch.<br/>
        /// Included only in responses
        /// </param>
        public InlinedResponses(
            global::System.Collections.Generic.IList<global::G.InlinedResponse>? inlinedResponses1)
        {
            this.InlinedResponses1 = inlinedResponses1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedResponses" /> class.
        /// </summary>
        public InlinedResponses()
        {
        }
    }
}