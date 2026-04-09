//HintName: G.Models.BuiltInTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A provider-native built-in tool (e.g. web search, code interpreter, bash).
    /// </summary>
    public sealed partial class BuiltInTool
    {
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BuiltInToolTypeJsonConverter))]
        public global::G.BuiltInToolType Type { get; set; } = default!;

        /// <summary>
        /// Provider-specific tool configuration. Structure varies by provider and tool type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public object Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInTool" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="provider"></param>
        /// <param name="type"></param>
        /// <param name="config">
        /// Provider-specific tool configuration. Structure varies by provider and tool type.
        /// </param>
        public BuiltInTool(
            string id,
            string name,
            string description,
            string provider,
            global::G.BuiltInToolType type,
            object config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInTool" /> class.
        /// </summary>
        public BuiltInTool()
        {
        }
    }
}