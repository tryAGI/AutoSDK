//HintName: G.Models.TaskResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskResponse
    {
        /// <summary>
        /// Response code. 0 indicates success.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Response message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique request ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.TaskData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
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
        public TaskResponse(
            int? code,
            string? message,
            string? requestId,
            global::G.TaskData? data)
        {
            this.Code = code;
            this.Message = message;
            this.RequestId = requestId;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        public TaskResponse()
        {
        }
    }
}