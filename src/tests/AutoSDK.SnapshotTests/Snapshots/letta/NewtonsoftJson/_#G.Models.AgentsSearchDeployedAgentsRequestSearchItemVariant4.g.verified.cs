//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequestSearchItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator Operator { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant4" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant4(
            string value,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field field,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator @operator)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant4" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant4()
        {
        }
    }
}