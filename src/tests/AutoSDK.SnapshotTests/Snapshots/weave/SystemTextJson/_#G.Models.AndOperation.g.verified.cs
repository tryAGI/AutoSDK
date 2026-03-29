//HintName: G.Models.AndOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logical AND. All conditions must evaluate to true.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$and": [<br/>
    ///             {"$eq": [{"$getField": "op_name"}, {"$literal": "predict"}]},<br/>
    ///             {"$gt": [{"$getField": "summary.usage.tokens"}, {"$literal": 1000}]}<br/>
    ///         ]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class AndOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$and")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>> x_and { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AndOperation" /> class.
        /// </summary>
        /// <param name="x_and"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AndOperation(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.LiteralOperation, global::G.GetFieldOperator, global::G.ConvertOperation, global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>> x_and)
        {
            this.x_and = x_and ?? throw new global::System.ArgumentNullException(nameof(x_and));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndOperation" /> class.
        /// </summary>
        public AndOperation()
        {
        }
    }
}