//HintName: G.Models.Query.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Query
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$expr")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> x_expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="x_expr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Query(
            global::G.AnyOf<global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> x_expr)
        {
            this.x_expr = x_expr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        public Query()
        {
        }
    }
}