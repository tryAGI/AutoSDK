//HintName: G.Models.ApplyPatchCallContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Apply patch tool call block.
    /// </summary>
    public sealed partial class ApplyPatchCallContent
    {
        /// <summary>
        /// Default Value: apply_patch_call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApplyPatchCallContentTypeJsonConverter))]
        public global::G.ApplyPatchCallContentType? Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("operation")]
        public object? Operation { get; set; }

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
        /// Initializes a new instance of the <see cref="ApplyPatchCallContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: apply_patch_call
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="operation">
        /// Default Value: {}
        /// </param>
        /// <param name="status">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public ApplyPatchCallContent(
            global::G.ApplyPatchCallContentType? type,
            string? id,
            string? callId,
            object? operation,
            string? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId;
            this.Operation = operation;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallContent" /> class.
        /// </summary>
        public ApplyPatchCallContent()
        {
        }
    }
}