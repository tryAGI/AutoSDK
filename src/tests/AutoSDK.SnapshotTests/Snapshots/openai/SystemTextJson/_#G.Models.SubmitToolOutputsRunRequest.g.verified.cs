//HintName: G.Models.SubmitToolOutputsRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRunRequest
    {
        /// <summary>
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A list of tools for which the outputs are being submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput> ToolOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequest" /> class.
        /// </summary>
        /// <param name="stream">
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </param>
        /// <param name="toolOutputs">
        /// A list of tools for which the outputs are being submitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitToolOutputsRunRequest(
            global::System.Collections.Generic.IList<global::G.SubmitToolOutputsRunRequestToolOutput> toolOutputs,
            bool? stream)
        {
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRunRequest" /> class.
        /// </summary>
        public SubmitToolOutputsRunRequest()
        {
        }
    }
}