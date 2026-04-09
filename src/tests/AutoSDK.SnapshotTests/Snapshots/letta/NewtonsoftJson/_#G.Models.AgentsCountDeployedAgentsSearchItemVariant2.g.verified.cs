//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCountDeployedAgentsSearchItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldJsonConverter))]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant2Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorJsonConverter))]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant2Operator Operator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant2" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="value"></param>
        /// <param name="field"></param>
        public AgentsCountDeployedAgentsSearchItemVariant2(
            global::G.AgentsCountDeployedAgentsSearchItemVariant2Operator @operator,
            string value,
            global::G.AgentsCountDeployedAgentsSearchItemVariant2Field field)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant2" /> class.
        /// </summary>
        public AgentsCountDeployedAgentsSearchItemVariant2()
        {
        }
    }
}