//HintName: G.Models.CancelAgentRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelAgentRunRequest
    {
        /// <summary>
        /// Optional list of run IDs to cancel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_ids")]
        public global::System.Collections.Generic.IList<string>? RunIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAgentRunRequest" /> class.
        /// </summary>
        /// <param name="runIds">
        /// Optional list of run IDs to cancel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelAgentRunRequest(
            global::System.Collections.Generic.IList<string>? runIds)
        {
            this.RunIds = runIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAgentRunRequest" /> class.
        /// </summary>
        public CancelAgentRunRequest()
        {
        }
    }
}