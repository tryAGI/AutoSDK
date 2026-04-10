//HintName: G.Models.ShellCallOutputContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Shell tool output block.
    /// </summary>
    public sealed partial class ShellCallOutputContent
    {
        /// <summary>
        /// Default Value: shell_call_output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ShellCallOutputContentTypeJsonConverter))]
        public global::G.ShellCallOutputContentType? Type { get; set; }

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
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::System.Collections.Generic.IList<object>? Output { get; set; }

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
        /// Initializes a new instance of the <see cref="ShellCallOutputContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: shell_call_output
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="output">
        /// Default Value: []
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public ShellCallOutputContent(
            global::G.ShellCallOutputContentType? type,
            string? id,
            string? callId,
            global::System.Collections.Generic.IList<object>? output,
            string? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId;
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellCallOutputContent" /> class.
        /// </summary>
        public ShellCallOutputContent()
        {
        }
    }
}