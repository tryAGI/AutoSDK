//HintName: G.Models.AgentBlueprintWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBlueprintWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentBlueprintWriteTypeJsonConverter))]
        public global::G.AgentBlueprintWriteType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentConfigValueWrite> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBlueprintWrite" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="values"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        public AgentBlueprintWrite(
            global::G.AgentBlueprintWriteType type,
            global::System.Collections.Generic.IList<global::G.AgentConfigValueWrite> values,
            global::System.Guid? id,
            string? description)
        {
            this.Id = id;
            this.Type = type;
            this.Description = description;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBlueprintWrite" /> class.
        /// </summary>
        public AgentBlueprintWrite()
        {
        }
    }
}