//HintName: G.Models.ServerToolUseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Server-side tool use block (e.g. web search, code execution).
    /// </summary>
    public sealed partial class ServerToolUseContent
    {
        /// <summary>
        /// Default Value: server_tool_use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerToolUseContentTypeJsonConverter))]
        public global::G.ServerToolUseContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolUseContent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: server_tool_use
        /// </param>
        /// <param name="input">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerToolUseContent(
            string id,
            string name,
            global::G.ServerToolUseContentType? type,
            object? input)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerToolUseContent" /> class.
        /// </summary>
        public ServerToolUseContent()
        {
        }
    }
}