﻿//HintName: G.Models.ActionsReRunJobForWorkflowRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsReRunJobForWorkflowRunRequest
    {
        /// <summary>
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_debug_logging")]
        public bool? EnableDebugLogging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReRunJobForWorkflowRunRequest" /> class.
        /// </summary>
        /// <param name="enableDebugLogging">
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsReRunJobForWorkflowRunRequest(
            bool? enableDebugLogging)
        {
            this.EnableDebugLogging = enableDebugLogging;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReRunJobForWorkflowRunRequest" /> class.
        /// </summary>
        public ActionsReRunJobForWorkflowRunRequest()
        {
        }
    }
}