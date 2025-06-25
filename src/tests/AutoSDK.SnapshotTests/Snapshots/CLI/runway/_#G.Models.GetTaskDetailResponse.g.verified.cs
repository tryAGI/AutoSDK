﻿//HintName: G.Models.GetTaskDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTaskDetailResponse
    {
        /// <summary>
        /// Unique identifier of the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Current status of the task:<br/>
        /// - **PENDING**: The task is waiting in the queue.<br/>
        /// - **THROTTLED**: The task is waiting to be enqueued due to other running jobs.<br/>
        /// - **RUNNING**: The task is currently being processed.<br/>
        /// - **SUCCEEDED**: The task completed successfully.<br/>
        /// - **FAILED**: The task failed.<br/>
        /// - **CANCELLED**: The task was aborted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetTaskDetailResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetTaskDetailResponseStatus Status { get; set; }

        /// <summary>
        /// Timestamp when the task was submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Progress of the task. Only present when the task is in **RUNNING** state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public float? Progress { get; set; }

        /// <summary>
        /// URLs to the task's output. Only present when the task is in **SUCCEEDED** state. These URLs expire within 24-48 hours; fetch the task again to get fresh URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<string>? Output { get; set; }

        /// <summary>
        /// Reason for the task's failure. Only present when the task is in **FAILED** state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        public string? Failure { get; set; }

        /// <summary>
        /// Machine-readable error code for the failure. Only present when the task is in **FAILED** state. The code follows a dot-separated structure, with the most generic part on the left and the most specific part on the right (e.g., `SAFETY.INPUT.IMAGE`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureCode")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskDetailResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the task.
        /// </param>
        /// <param name="status">
        /// Current status of the task:<br/>
        /// - **PENDING**: The task is waiting in the queue.<br/>
        /// - **THROTTLED**: The task is waiting to be enqueued due to other running jobs.<br/>
        /// - **RUNNING**: The task is currently being processed.<br/>
        /// - **SUCCEEDED**: The task completed successfully.<br/>
        /// - **FAILED**: The task failed.<br/>
        /// - **CANCELLED**: The task was aborted.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the task was submitted.
        /// </param>
        /// <param name="progress">
        /// Progress of the task. Only present when the task is in **RUNNING** state.
        /// </param>
        /// <param name="output">
        /// URLs to the task's output. Only present when the task is in **SUCCEEDED** state. These URLs expire within 24-48 hours; fetch the task again to get fresh URLs.
        /// </param>
        /// <param name="failure">
        /// Reason for the task's failure. Only present when the task is in **FAILED** state.
        /// </param>
        /// <param name="failureCode">
        /// Machine-readable error code for the failure. Only present when the task is in **FAILED** state. The code follows a dot-separated structure, with the most generic part on the left and the most specific part on the right (e.g., `SAFETY.INPUT.IMAGE`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTaskDetailResponse(
            global::System.Guid id,
            global::G.GetTaskDetailResponseStatus status,
            global::System.DateTime createdAt,
            float? progress,
            global::System.Collections.Generic.IList<string>? output,
            string? failure,
            string? failureCode)
        {
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Progress = progress;
            this.Output = output;
            this.Failure = failure;
            this.FailureCode = failureCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTaskDetailResponse" /> class.
        /// </summary>
        public GetTaskDetailResponse()
        {
        }
    }
}