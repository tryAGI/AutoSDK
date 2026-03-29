//HintName: G.Models.ShellCallContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Shell tool call block.
    /// </summary>
    public sealed partial class ShellCallContent
    {
        /// <summary>
        /// Default Value: shell_call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ShellCallContentType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public object? Action { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: shell_call
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="action">
        /// Default Value: {}
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public ShellCallContent(
            global::G.ShellCallContentType? type,
            string? id,
            string? callId,
            object? action,
            string? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId;
            this.Action = action;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallContent" /> class.
        /// </summary>
        public ShellCallContent()
        {
        }
    }
}