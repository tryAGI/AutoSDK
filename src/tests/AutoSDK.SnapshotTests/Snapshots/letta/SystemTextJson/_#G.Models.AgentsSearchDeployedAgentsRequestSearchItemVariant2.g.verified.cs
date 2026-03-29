//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequestSearchItemVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant2" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="value"></param>
        /// <param name="field"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSearchDeployedAgentsRequestSearchItemVariant2(
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator @operator,
            string value,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field field)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant2" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant2()
        {
        }
    }
}