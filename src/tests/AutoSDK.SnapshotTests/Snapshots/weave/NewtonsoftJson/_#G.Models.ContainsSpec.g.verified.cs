//HintName: G.Models.ContainsSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for the `$contains` operation.<br/>
    /// - `input`: The string to search.<br/>
    /// - `substr`: The substring to search for.<br/>
    /// - `case_insensitive`: If true, match is case-insensitive.
    /// </summary>
    public sealed partial class ContainsSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("substr", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Substr { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("case_insensitive")]
        public bool? CaseInsensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="substr"></param>
        /// <param name="caseInsensitive">
        /// Default Value: false
        /// </param>
        public ContainsSpec(
            global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> input,
            global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> substr,
            bool? caseInsensitive)
        {
            this.Input = input;
            this.Substr = substr;
            this.CaseInsensitive = caseInsensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsSpec" /> class.
        /// </summary>
        public ContainsSpec()
        {
        }
    }
}