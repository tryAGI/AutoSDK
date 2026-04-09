//HintName: G.Models.Equation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Equation
    {
        /// <summary>
        /// Left side of the equation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left", Required = global::Newtonsoft.Json.Required.Always)]
        public string Left { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EquationOperatorJsonConverter))]
        public global::G.EquationOperator Operator { get; set; } = default!;

        /// <summary>
        /// Right side of the equation. The right side of the equation not required when "exists" or "not_exist" are selected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("right")]
        public string? Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Equation" /> class.
        /// </summary>
        /// <param name="left">
        /// Left side of the equation
        /// </param>
        /// <param name="operator"></param>
        /// <param name="right">
        /// Right side of the equation. The right side of the equation not required when "exists" or "not_exist" are selected.
        /// </param>
        public Equation(
            string left,
            global::G.EquationOperator @operator,
            string? right)
        {
            this.Left = left ?? throw new global::System.ArgumentNullException(nameof(left));
            this.Operator = @operator;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Equation" /> class.
        /// </summary>
        public Equation()
        {
        }
    }
}