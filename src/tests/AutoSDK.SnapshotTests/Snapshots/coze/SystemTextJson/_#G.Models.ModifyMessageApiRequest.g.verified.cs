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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModifyMessageApiRequestContentTypeJsonConverter))]
        public global::G.ModifyMessageApiRequestContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMessageApiRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// 内容
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="metaData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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