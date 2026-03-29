//HintName: G.Models.SearchFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a filter with AND, OR, and NOT conditions.
    /// </summary>
    public sealed partial class SearchFilter
    {
        /// <summary>
        /// List of conditions or filters to be ANDed together
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? All { get; set; }

        /// <summary>
        /// List of conditions or filters to be ORed together
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? Any { get; set; }

        /// <summary>
        /// List of conditions or filters to be NOTed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("none")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? None { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilter" /> class.
        /// </summary>
        /// <param name="all">
        /// List of conditions or filters to be ANDed together
        /// </param>
        /// <param name="any">
        /// List of conditions or filters to be ORed together
        /// </param>
        /// <param name="none">
        /// List of conditions or filters to be NOTed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchFilter(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? all,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? any,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>? none)
        {
            this.All = all;
            this.Any = any;
            this.None = none;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilter" /> class.
        /// </summary>
        public SearchFilter()
        {
        }
    }
}