//HintName: G.Models.InlinedEmbedContentResponses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The responses to the requests in the batch.
    /// </summary>
    public sealed partial class InlinedEmbedContentResponses
    {
        /// <summary>
        /// Output only. The responses to the requests in the batch.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inlinedResponses")]
        public global::System.Collections.Generic.IList<global::G.InlinedEmbedContentResponse>? InlinedResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentResponses" /> class.
        /// </summary>
        /// <param name="inlinedResponses">
        /// Output only. The responses to the requests in the batch.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlinedEmbedContentResponses(
            global::System.Collections.Generic.IList<global::G.InlinedEmbedContentResponse>? inlinedResponses)
        {
            this.InlinedResponses = inlinedResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedEmbedContentResponses" /> class.
        /// </summary>
        public InlinedEmbedContentResponses()
        {
        }
    }
}