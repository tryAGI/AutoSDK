//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequestSearchItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field Field { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="field"></param>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant1(
            string value,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field field)
        {
            this.Field = field;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant1" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant1()
        {
        }
    }
}