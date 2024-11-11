//HintName: G.Models.TriggerAsyncNamespaceLatestModelBody.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("taskInputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> TaskInputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerAsyncNamespaceLatestModelBody" /> class.
        /// </summary>
        /// <param name="taskInputs">
        /// Model inference inputs.
        /// </param>
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