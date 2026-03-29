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
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// This is the name of the parameter that you want to check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param", Required = global::Newtonsoft.Json.Required.Always)]
        public string Param { get; set; } = default!;

        /// <summary>
        /// This is the value you want to compare against the parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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