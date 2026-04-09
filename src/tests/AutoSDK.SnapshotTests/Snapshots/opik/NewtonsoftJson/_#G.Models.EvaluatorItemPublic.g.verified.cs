//HintName: G.Models.EvaluatorItemPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default evaluators for items in this version<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class EvaluatorItemPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvaluatorItemPublicTypeJsonConverter))]
        public global::G.EvaluatorItemPublicType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonNodePublic Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorItemPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="config"></param>
        public EvaluatorItemPublic(
            string name,
            global::G.EvaluatorItemPublicType type,
            global::G.JsonNodePublic config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorItemPublic" /> class.
        /// </summary>
        public EvaluatorItemPublic()
        {
        }
    }
}