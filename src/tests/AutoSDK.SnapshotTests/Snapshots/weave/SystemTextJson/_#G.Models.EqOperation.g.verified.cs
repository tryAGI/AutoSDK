//HintName: G.Models.EqOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Equality check between two operands.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$eq": [{"$getField": "op_name"}, {"$literal": "predict"}]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class EqOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$eq")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>> x_eq { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EqOperation" /> class.
        /// </summary>
        /// <param name="x_eq"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EqOperation(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>> x_eq)
        {
            this.x_eq = x_eq ?? throw new global::System.ArgumentNullException(nameof(x_eq));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EqOperation" /> class.
        /// </summary>
        public EqOperation()
        {
        }
    }
}