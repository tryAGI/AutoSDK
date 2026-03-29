//HintName: G.Models.ConvertSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies conversion details for `$convert`.<br/>
    /// - `input`: The operand to convert.<br/>
    /// - `to`: The type to convert to.
    /// </summary>
    public sealed partial class ConvertSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConvertSpecTo To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="to"></param>
        public ConvertSpec(
            global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> input,
            global::G.ConvertSpecTo to)
        {
            this.Input = input;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpec" /> class.
        /// </summary>
        public ConvertSpec()
        {
        }
    }
}