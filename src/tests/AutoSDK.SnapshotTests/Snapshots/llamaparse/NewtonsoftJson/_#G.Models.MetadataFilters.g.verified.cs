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
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.MetadataFilter, global::G.MetadataFilters>> Filters { get; set; } = default!;

        /// <summary>
        /// Default Value: and
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public global::G.FilterCondition? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilters" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="condition">
        /// Default Value: and
        /// </param>
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