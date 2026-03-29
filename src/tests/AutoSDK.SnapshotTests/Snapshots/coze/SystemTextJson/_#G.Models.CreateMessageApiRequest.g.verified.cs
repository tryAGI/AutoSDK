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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateMessageApiRequestContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateMessageApiRequestContentType ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// 已TODO 字段打平
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateMessageApiRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateMessageApiRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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