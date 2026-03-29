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
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

        /// <summary>
        /// ID of task to annotate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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