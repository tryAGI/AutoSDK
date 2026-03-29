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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ServerToolUseContentType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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