//HintName: G.Models.ModifyMessageApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyMessageApiRequest
    {
        /// <summary>
        /// 内容
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public global::G.ModifyMessageApiRequestContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMessageApiRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="metaData"></param>
        public ModifyMessageApiRequest(
            string? content,
            global::G.ModifyMessageApiRequestContentType? contentType,
            global::System.Collections.Generic.Dictionary<string, string>? metaData)
        {
            this.Content = content;
            this.ContentType = contentType;
            this.MetaData = metaData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMessageApiRequest" /> class.
        /// </summary>
        public ModifyMessageApiRequest()
        {
        }
    }
}