//HintName: G.Models.TaskListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskListResponse
    {
        /// <summary>
        /// Response code. 0 indicates success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Response message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique request ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.TaskListData>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// Response code. 0 indicates success.
        /// </param>
        /// <param name="message">
        /// Response message.
        /// </param>
        /// <param name="requestId">
        /// Unique request ID.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskListResponse(
            int? code,
            string? message,
            string? requestId,
            global::System.Collections.Generic.IList<global::G.TaskListData>? data)
        {
            this.Code = code;
            this.Message = message;
            this.RequestId = requestId;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListResponse" /> class.
        /// </summary>
        public TaskListResponse()
        {
        }
    }
}