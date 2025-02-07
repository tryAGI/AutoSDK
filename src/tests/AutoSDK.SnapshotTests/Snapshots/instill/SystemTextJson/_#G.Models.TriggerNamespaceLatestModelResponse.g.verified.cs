//HintName: G.Models.TriggerNamespaceLatestModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespaceLatestModelResponse contains the model inference results.
    /// </summary>
    public sealed partial class TriggerNamespaceLatestModelResponse
    {
        /// <summary>
        /// Task type.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AITaskJsonConverter))]
        public global::G.AITask? Task { get; set; }

        /// <summary>
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskOutputs")]
        public global::System.Collections.Generic.IList<object>? TaskOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceLatestModelResponse" /> class.
        /// </summary>
        /// <param name="task">
        /// Task type.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="taskOutputs">
        /// Model inference outputs.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerNamespaceLatestModelResponse(
            global::G.AITask? task,
            global::System.Collections.Generic.IList<object>? taskOutputs)
        {
            this.Task = task;
            this.TaskOutputs = taskOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespaceLatestModelResponse" /> class.
        /// </summary>
        public TriggerNamespaceLatestModelResponse()
        {
        }
    }
}