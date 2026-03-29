//HintName: G.Models.CreateMessageApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageApiRequest
    {
        /// <summary>
        /// 内容
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMessageApiRequestContentType ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 已TODO 字段打平
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateMessageApiRequestRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageApiRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="role">
        /// 已TODO 字段打平
        /// </param>
        /// <param name="metaData"></param>
        public CreateMessageApiRequest(
            string content,
            global::G.CreateMessageApiRequestContentType contentType,
            global::G.CreateMessageApiRequestRole role,
            global::System.Collections.Generic.Dictionary<string, string>? metaData)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ContentType = contentType;
            this.MetaData = metaData;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageApiRequest" /> class.
        /// </summary>
        public CreateMessageApiRequest()
        {
        }
    }
}