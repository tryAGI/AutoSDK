//HintName: G.Models.CompoundFilter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Combine multiple filters using `and` or `or`.
    /// </summary>
    public sealed partial class CompoundFilter
    {
        /// <summary>
        /// Type of operation: `and` or `or`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompoundFilterType Type { get; set; } = default!;

        /// <summary>
        /// Array of filters to combine. Items can be `ComparisonFilter` or `CompoundFilter`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ComparisonFilter, object>> Filters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of operation: `and` or `or`.
        /// </param>
        /// <param name="filters">
        /// Array of filters to combine. Items can be `ComparisonFilter` or `CompoundFilter`.
        /// </param>
        public CompoundFilter(
            global::G.CompoundFilterType type,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ComparisonFilter, object>> filters)
        {
            this.Type = type;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        public CompoundFilter()
        {
        }
    }
}