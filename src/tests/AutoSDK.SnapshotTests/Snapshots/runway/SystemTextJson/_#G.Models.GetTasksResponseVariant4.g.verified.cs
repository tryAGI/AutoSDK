//HintName: G.Models.GetTasksResponseVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A running task
    /// </summary>
    public sealed partial class GetTasksResponseVariant4
    {
        /// <summary>
        /// The ID of the task being returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The timestamp that the task was submitted at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"RUNNING"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "RUNNING";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant4" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="status"></param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant4(
            global::System.Guid id,
            global::System.DateTime createdAt,
            double progress,
            string status = "RUNNING")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Progress = progress;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant4" /> class.
        /// </summary>
        public GetTasksResponseVariant4()
        {
        }
    }
}