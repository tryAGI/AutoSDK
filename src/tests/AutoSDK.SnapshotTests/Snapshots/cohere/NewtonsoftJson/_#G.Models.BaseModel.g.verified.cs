//HintName: G.Models.BaseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base model used for fine-tuning.
    /// </summary>
    public sealed partial class BaseModel
    {
        /// <summary>
        /// The name of the base model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The type of the base model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </summary>
        /// <default>global::G.BaseType.UNSPECIFIED</default>
        [global::Newtonsoft.Json.JsonProperty("base_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseType BaseType { get; set; } = default!;

        /// <summary>
        /// Deprecated: The fine-tuning strategy.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        public global::G.Strategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the base model.
        /// </param>
        /// <param name="version">
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="baseType">
        /// The type of the base model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </param>
        /// <param name="strategy">
        /// Deprecated: The fine-tuning strategy.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </param>
        public BaseModel(
            global::G.BaseType baseType,
            string? name,
            string? version,
            global::G.Strategy? strategy)
        {
            this.BaseType = baseType;
            this.Name = name;
            this.Version = version;
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseModel" /> class.
        /// </summary>
        public BaseModel()
        {
        }
    }
}