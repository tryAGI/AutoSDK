//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCountDeployedAgentsSearchItemVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldJsonConverter))]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant6Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorJsonConverter))]
        public global::G.AgentsCountDeployedAgentsSearchItemVariant6Operator Operator { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant6" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="field"></param>
        /// <param name="operator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCountDeployedAgentsSearchItemVariant6(
            string value,
            global::G.AgentsCountDeployedAgentsSearchItemVariant6Field field,
            global::G.AgentsCountDeployedAgentsSearchItemVariant6Operator @operator)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant6" /> class.
        /// </summary>
        public AgentsCountDeployedAgentsSearchItemVariant6()
        {
        }
    }
}