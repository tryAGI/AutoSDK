//HintName: G.Models.FilterOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request model for a filter comparison operation.
    /// </summary>
    public sealed partial class FilterOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eq")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Eq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ne")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Ne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gt")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gte")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lt")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lte")]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includes")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Includes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludes")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Excludes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterOperation" /> class.
        /// </summary>
        /// <param name="eq"></param>
        /// <param name="ne"></param>
        /// <param name="gt"></param>
        /// <param name="gte"></param>
        /// <param name="lt"></param>
        /// <param name="lte"></param>
        /// <param name="includes"></param>
        /// <param name="excludes"></param>
        public FilterOperation(
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? eq,
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? ne,
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? gt,
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? gte,
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? lt,
            global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? lte,
            global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? includes,
            global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? excludes)
        {
            this.Eq = eq;
            this.Ne = ne;
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
            this.Includes = includes;
            this.Excludes = excludes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterOperation" /> class.
        /// </summary>
        public FilterOperation()
        {
        }
    }
}