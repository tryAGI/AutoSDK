//HintName: G.Models.GetTasksResponseVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A failed task
    /// </summary>
    public sealed partial class GetTasksResponseVariant5
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
        /// <default>"FAILED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "FAILED";

        /// <summary>
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Failure { get; set; }

        /// <summary>
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCode")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant5" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="failure">
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </param>
        /// <param name="failureCode">
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTasksResponseVariant5(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string failure,
            string? failureCode,
            string status = "FAILED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
            this.FailureCode = failureCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTasksResponseVariant5" /> class.
        /// </summary>
        public GetTasksResponseVariant5()
        {
        }
    }
}