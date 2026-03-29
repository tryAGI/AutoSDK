//HintName: G.Models.EnterMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterMessage
    {
        /// <summary>
        /// 内容
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// text/card/object_string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType">
        /// text/card/object_string
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="type"></param>
        public EnterMessage(
            string role,
            string? content,
            string? contentType,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            string? type)
        {
            this.Content = content;
            this.ContentType = contentType;
            this.MetaData = metaData;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage" /> class.
        /// </summary>
        public EnterMessage()
        {
        }
    }
}