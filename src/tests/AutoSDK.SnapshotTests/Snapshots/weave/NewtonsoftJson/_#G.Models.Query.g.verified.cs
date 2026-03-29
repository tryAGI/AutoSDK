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
        [global::Newtonsoft.Json.JsonProperty("$expr", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.AndOperation, global::G.OrOperation, global::G.NotOperation, global::G.EqOperation, global::G.GtOperation, global::G.LtOperation, global::G.GteOperation, global::G.LteOperation, global::G.InOperation, global::G.ContainsOperation> x_expr { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="x_expr"></param>
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