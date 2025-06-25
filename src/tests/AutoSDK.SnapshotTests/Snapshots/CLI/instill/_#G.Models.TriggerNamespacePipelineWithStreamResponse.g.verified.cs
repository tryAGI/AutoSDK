﻿//HintName: G.Models.TriggerNamespacePipelineWithStreamResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineWithStreamResponse contains the pipeline execution results, i.e.,<br/>
    /// the multiple model inference outputs.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineWithStreamResponse
    {
        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.TriggerMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineWithStreamResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="metadata">
        /// Traces of the pipeline inference.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerNamespacePipelineWithStreamResponse(
            global::System.Collections.Generic.IList<object>? outputs,
            global::G.TriggerMetadata? metadata)
        {
            this.Outputs = outputs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineWithStreamResponse" /> class.
        /// </summary>
        public TriggerNamespacePipelineWithStreamResponse()
        {
        }
    }
}