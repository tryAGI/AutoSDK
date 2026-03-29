//HintName: G.Models.FeedbackPayloadSchemaRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response with discovered feedback payload paths and types.
    /// </summary>
    public sealed partial class FeedbackPayloadSchemaRes
    {
        /// <summary>
        /// Discovered leaf paths with inferred value types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paths")]
        public global::System.Collections.Generic.IList<global::G.FeedbackPayloadPath>? Paths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadSchemaRes" /> class.
        /// </summary>
        /// <param name="paths">
        /// Discovered leaf paths with inferred value types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackPayloadSchemaRes(
            global::System.Collections.Generic.IList<global::G.FeedbackPayloadPath>? paths)
        {
            this.Paths = paths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadSchemaRes" /> class.
        /// </summary>
        public FeedbackPayloadSchemaRes()
        {
        }
    }
}