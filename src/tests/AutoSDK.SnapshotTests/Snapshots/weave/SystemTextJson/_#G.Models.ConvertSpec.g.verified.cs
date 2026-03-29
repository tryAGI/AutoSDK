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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConvertSpecToJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConvertSpecTo To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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