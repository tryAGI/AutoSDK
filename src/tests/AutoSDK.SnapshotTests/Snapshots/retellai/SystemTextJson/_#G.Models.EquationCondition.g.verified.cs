//HintName: G.Models.EquationCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EquationCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EquationConditionTypeJsonConverter))]
        public global::G.EquationConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Equation> Equations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EquationConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EquationConditionOperator Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationCondition" /> class.
        /// </summary>
        /// <param name="equations"></param>
        /// <param name="operator"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EquationCondition(
            global::System.Collections.Generic.IList<global::G.Equation> equations,
            global::G.EquationConditionOperator @operator,
            global::G.EquationConditionType type)
        {
            this.Type = type;
            this.Equations = equations ?? throw new global::System.ArgumentNullException(nameof(equations));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationCondition" /> class.
        /// </summary>
        public EquationCondition()
        {
        }
    }
}