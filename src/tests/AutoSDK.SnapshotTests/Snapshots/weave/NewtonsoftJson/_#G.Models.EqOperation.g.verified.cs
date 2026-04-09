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
        [global::Newtonsoft.Json.JsonProperty("$eq", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>> x_eq { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EqOperation" /> class.
        /// </summary>
        /// <param name="x_eq"></param>
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