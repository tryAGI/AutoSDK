//HintName: G.Models.MLInteractiveAnnotatingRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for ML interactive annotating request.
    /// </summary>
    public sealed partial class MLInteractiveAnnotatingRequestRequest
    {
        /// <summary>
        /// Context for ML model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public object? Context { get; set; }

        /// <summary>
        /// ID of task to annotate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public int Task { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLInteractiveAnnotatingRequestRequest" /> class.
        /// </summary>
        /// <param name="task">
        /// ID of task to annotate
        /// </param>
        /// <param name="context">
        /// Context for ML model
        /// </param>
        public MLInteractiveAnnotatingRequestRequest(
            int task,
            object? context)
        {
            this.Context = context;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLInteractiveAnnotatingRequestRequest" /> class.
        /// </summary>
        public MLInteractiveAnnotatingRequestRequest()
        {
        }
    }
}