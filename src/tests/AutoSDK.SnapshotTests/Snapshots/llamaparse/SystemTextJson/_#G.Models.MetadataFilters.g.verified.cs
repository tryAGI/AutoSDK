//HintName: G.Models.MetadataFilters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata filters for vector stores.
    /// </summary>
    public sealed partial class MetadataFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.MetadataFilter, global::G.MetadataFilters>> Filters { get; set; }

        /// <summary>
        /// Default Value: and
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::G.FilterCondition? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilters" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="condition">
        /// Default Value: and
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataFilters(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.MetadataFilter, global::G.MetadataFilters>> filters,
            global::G.FilterCondition? condition)
        {
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilters" /> class.
        /// </summary>
        public MetadataFilters()
        {
        }
    }
}