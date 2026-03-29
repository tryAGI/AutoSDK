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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substr")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Substr { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_insensitive")]
        public bool? CaseInsensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="substr"></param>
        /// <param name="caseInsensitive">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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