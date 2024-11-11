//HintName: G.Models.TriggerAsyncNamespacePipelineReleaseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineReleaseRequest represents a request to trigger a pinned<br/>
    /// release of a user-owned pipeline asynchronously.
    /// </summary>
    public sealed partial class TriggerAsyncNamespacePipelineReleaseBody
    {
        /// <summary>
        /// Pipeline input parameters, it will be deprecated soon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.TriggerData>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineReleaseBody" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TriggerAsyncNamespacePipelineReleaseBody(
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData>? data)
        {
            this.Inputs = inputs;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespacePipelineReleaseBody" /> class.
        /// </summary>
        public TriggerAsyncNamespacePipelineReleaseBody()
        {
        }
    }
}