//HintName: G.Models.WorkflowUnconditionalModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUnconditionalModelOutput
    {
        /// <summary>
        /// Optional human-readable label for the condition used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Default Value: unconditional
        /// </summary>
        /// <default>"unconditional"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "unconditional";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUnconditionalModelOutput" /> class.
        /// </summary>
        /// <param name="label">
        /// Optional human-readable label for the condition used throughout the UI.
        /// </param>
        /// <param name="type">
        /// Default Value: unconditional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowUnconditionalModelOutput(
            string? label,
            string type = "unconditional")
        {
            this.Label = label;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUnconditionalModelOutput" /> class.
        /// </summary>
        public WorkflowUnconditionalModelOutput()
        {
        }
    }
}