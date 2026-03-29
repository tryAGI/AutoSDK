//HintName: G.Models.EnterMessage1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterMessage1
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
        public global::G.EnterMessage1ContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnterMessage1Role Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EnterMessage1Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage1" /> class.
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
        public EnterMessage1(
            global::G.EnterMessage1Role role,
            string? content,
            global::G.EnterMessage1ContentType? contentType,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            global::G.EnterMessage1Type? type)
        {
            this.Content = content;
            this.ContentType = contentType;
            this.MetaData = metaData;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage1" /> class.
        /// </summary>
        public EnterMessage1()
        {
        }
    }
}