//HintName: G.Models.CodeContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code content block (e.g. from code execution tools).
    /// </summary>
    public sealed partial class CodeContent
    {
        /// <summary>
        /// Default Value: code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeContent" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="type">
        /// Default Value: code
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="containerId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public CodeContent(
            string code,
            global::G.CodeContentType? type,
            string? id,
            string? containerId)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Id = id;
            this.ContainerId = containerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeContent" /> class.
        /// </summary>
        public CodeContent()
        {
        }
    }
}