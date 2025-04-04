﻿//HintName: G.Models.TriggerNamespaceModelBinaryFileUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespaceModelBinaryFileUploadResponse contains the model inference results.
    /// </summary>
    public sealed partial class TriggerNamespaceModelBinaryFileUploadResponse
    {
        /// <summary>
        /// Task type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AITask Task { get; set; } = default!;

        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("taskOutputs")]
        public global::System.Collections.Generic.IList<object>? TaskOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceModelBinaryFileUploadResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// Task type.
        /// </param>
        /// <param name="taskOutputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
        public TriggerNamespaceModelBinaryFileUploadResponse(
            global::G.AITask task,
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.Task = task;
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceModelBinaryFileUploadResponse" /> class.
        /// </summary>
        public TriggerNamespaceModelBinaryFileUploadResponse()
        {
        }
    }
}