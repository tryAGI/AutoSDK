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
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldJsonConverter))]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant2Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentsCountDeployedAgentsSearchItemVariant2Operator Operator { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant2" /> class.
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="value"></param>
        /// <param name="field"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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