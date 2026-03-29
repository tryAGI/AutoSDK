//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequestSearchItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorJsonConverter))]
        public global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant3" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="field"></param>
        /// <param name="operator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSearchDeployedAgentsRequestSearchItemVariant3(
            global::System.Collections.Generic.IList<string> value,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3Field field,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator @operator)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant3" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant3()
        {
        }
    }
}