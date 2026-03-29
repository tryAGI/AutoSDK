//HintName: G.Models.Condition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Condition
    {
        /// <summary>
        /// This is the operator you want to use to compare the parameter and value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConditionOperator Operator { get; set; }

        /// <summary>
        /// This is the name of the parameter that you want to check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Param { get; set; }

        /// <summary>
        /// This is the value you want to compare against the parameter.
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
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        /// <param name="operator">
        /// This is the operator you want to use to compare the parameter and value.
        /// </param>
        /// <param name="param">
        /// This is the name of the parameter that you want to check.
        /// </param>
        /// <param name="value">
        /// This is the value you want to compare against the parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Condition(
            global::G.ConditionOperator @operator,
            string param,
            string value)
        {
            this.Operator = @operator;
            this.Param = param ?? throw new global::System.ArgumentNullException(nameof(param));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Condition" /> class.
        /// </summary>
        public Condition()
        {
        }
    }
}