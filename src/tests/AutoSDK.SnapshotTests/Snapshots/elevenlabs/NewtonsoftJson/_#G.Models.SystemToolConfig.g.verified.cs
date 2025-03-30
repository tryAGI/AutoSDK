//HintName: G.Models.SystemToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A system tool is a tool that is used to call a system method in the server
    /// </summary>
    public sealed partial class SystemToolConfig
    {
        /// <summary>
        /// The type of tool<br/>
        /// Default Value: system
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SystemToolConfigType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: system
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public SystemToolConfig(
            string name,
            string description,
            global::G.SystemToolConfigType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfig" /> class.
        /// </summary>
        public SystemToolConfig()
        {
        }
    }
}