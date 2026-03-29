//HintName: G.Models.StructuredFilterGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A group of filters combined with AND or OR logic. Can be nested recursively.
    /// </summary>
    public sealed partial class StructuredFilterGroup
    {
        /// <summary>
        /// How to combine the filters in this group.<br/>
        /// Default Value: AND
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logic")]
        public global::G.StructuredFilterGroupLogic? Logic { get; set; }

        /// <summary>
        /// List of filters or nested filter groups.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.StructuredFilter, global::G.StructuredFilterGroup>> Filters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilterGroup" /> class.
        /// </summary>
        /// <param name="filters">
        /// List of filters or nested filter groups.
        /// </param>
        /// <param name="logic">
        /// How to combine the filters in this group.<br/>
        /// Default Value: AND
        /// </param>
        public StructuredFilterGroup(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.StructuredFilter, global::G.StructuredFilterGroup>> filters,
            global::G.StructuredFilterGroupLogic? logic)
        {
            this.Logic = logic;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilterGroup" /> class.
        /// </summary>
        public StructuredFilterGroup()
        {
        }
    }
}