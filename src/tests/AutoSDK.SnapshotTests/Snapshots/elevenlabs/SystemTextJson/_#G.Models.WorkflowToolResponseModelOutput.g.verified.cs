//HintName: G.Models.WorkflowToolResponseModelOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A common model for workflow tool responses.
    /// </summary>
    public sealed partial class WorkflowToolResponseModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::G.StepsItem2>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolResponseModelOutput" /> class.
        /// </summary>
        /// <param name="steps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolResponseModelOutput(
            global::System.Collections.Generic.IList<global::G.StepsItem2>? steps)
        {
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolResponseModelOutput" /> class.
        /// </summary>
        public WorkflowToolResponseModelOutput()
        {
        }
    }
}