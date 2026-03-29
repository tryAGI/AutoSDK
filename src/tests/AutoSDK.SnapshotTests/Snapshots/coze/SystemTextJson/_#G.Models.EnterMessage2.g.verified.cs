//HintName: G.Models.EnterMessage2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterMessage2
    {
        /// <summary>
        /// 如果是非 text，需要解析 JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// text, card, object_string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnterMessage2ContentTypeJsonConverter))]
        public global::G.EnterMessage2ContentType? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// user / assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnterMessage2RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnterMessage2Role Role { get; set; }

        /// <summary>
        /// function_call, tool_output, knowledge, answer, follow_up, verbose, (普通请求可以不填)<br/>
        ///  用户输入时可用：function_call，tool_output<br/>
        ///  不支持用户输入使用：follow_up，knowledge，verbose，answer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnterMessage2TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnterMessage2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage2" /> class.
        /// </summary>
        /// <param name="content">
        /// 如果是非 text，需要解析 JSON
        /// </param>
        /// <param name="role">
        /// user / assistant
        /// </param>
        /// <param name="type">
        /// function_call, tool_output, knowledge, answer, follow_up, verbose, (普通请求可以不填)<br/>
        ///  用户输入时可用：function_call，tool_output<br/>
        ///  不支持用户输入使用：follow_up，knowledge，verbose，answer
        /// </param>
        /// <param name="contentType">
        /// text, card, object_string
        /// </param>
        /// <param name="metaData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterMessage2(
            string content,
            global::G.EnterMessage2Role role,
            global::G.EnterMessage2Type type,
            global::G.EnterMessage2ContentType? contentType,
            global::System.Collections.Generic.Dictionary<string, string>? metaData)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ContentType = contentType;
            this.MetaData = metaData;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterMessage2" /> class.
        /// </summary>
        public EnterMessage2()
        {
        }
    }
}