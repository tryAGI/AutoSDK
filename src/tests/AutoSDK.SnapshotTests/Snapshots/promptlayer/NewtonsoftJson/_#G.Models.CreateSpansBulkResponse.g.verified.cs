//HintName: G.Models.CreateSpansBulkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansBulkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Spans { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_logs")]
        public global::System.Collections.Generic.IList<object>? RequestLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="spans"></param>
        /// <param name="requestLogs"></param>
        public CreateSpansBulkResponse(
            bool success,
            global::System.Collections.Generic.IList<object> spans,
            global::System.Collections.Generic.IList<object>? requestLogs)
        {
            this.Success = success;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.RequestLogs = requestLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulkResponse" /> class.
        /// </summary>
        public CreateSpansBulkResponse()
        {
        }
    }
}