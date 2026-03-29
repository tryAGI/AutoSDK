//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCountDeployedAgentsSearchItemVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant4Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant4Operator Operator { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant4" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        public AgentsCountDeployedAgentsSearchItemVariant4(
            string value,
            global::G.AgentsCountDeployedAgentsSearchItemVariant4Field field,
            global::G.AgentsCountDeployedAgentsSearchItemVariant4Operator @operator)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant4" /> class.
        /// </summary>
        public AgentsCountDeployedAgentsSearchItemVariant4()
        {
        }
    }
}