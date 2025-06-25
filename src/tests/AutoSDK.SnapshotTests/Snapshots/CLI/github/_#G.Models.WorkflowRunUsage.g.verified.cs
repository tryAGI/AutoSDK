﻿//HintName: G.Models.WorkflowRunUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workflow Run Usage
    /// </summary>
    public sealed partial class WorkflowRunUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkflowRunUsageBillable Billable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_duration_ms")]
        public int? RunDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsage" /> class.
        /// </summary>
        /// <param name="billable"></param>
        /// <param name="runDurationMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRunUsage(
            global::G.WorkflowRunUsageBillable billable,
            int? runDurationMs)
        {
            this.Billable = billable ?? throw new global::System.ArgumentNullException(nameof(billable));
            this.RunDurationMs = runDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUsage" /> class.
        /// </summary>
        public WorkflowRunUsage()
        {
        }
    }
}