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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EquationConditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Equation> Equations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EquationConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EquationCondition" /> class.
        /// </summary>
        /// <param name="equations"></param>
        /// <param name="operator"></param>
        /// <param name="type"></param>
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