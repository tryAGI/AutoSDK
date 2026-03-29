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
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Eq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ne")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Ne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>))]
        public global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>? Lte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Includes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<double?, int?, string, global::System.DateTime?, object>>? Excludes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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