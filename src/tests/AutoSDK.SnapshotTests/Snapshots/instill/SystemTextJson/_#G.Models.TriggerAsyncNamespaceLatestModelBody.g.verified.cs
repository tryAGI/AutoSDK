﻿//HintName: G.Models.TriggerAsyncNamespaceLatestModelBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerAsyncNamespaceLatestModelRequest represents a request to trigger a model inference<br/>
    /// asynchronously with the latest uploaded version.
    /// </summary>
    public sealed partial class TriggerAsyncNamespaceLatestModelBody
    {
        /// <summary>
        /// Model inference inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskInputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> TaskInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceLatestModelBody" /> class.
        /// </summary>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerAsyncNamespaceLatestModelBody(
            global::System.Collections.Generic.IList<object> taskInputs)
        {
            this.TaskInputs = taskInputs ?? throw new global::System.ArgumentNullException(nameof(taskInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceLatestModelBody" /> class.
        /// </summary>
        public TriggerAsyncNamespaceLatestModelBody()
        {
        }
    }
}