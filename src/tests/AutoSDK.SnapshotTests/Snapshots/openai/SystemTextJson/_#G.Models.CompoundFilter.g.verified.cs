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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompoundFilterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompoundFilterType Type { get; set; }

        /// <summary>
        /// Array of filters to combine. Items can be `ComparisonFilter` or `CompoundFilter`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.ComparisonFilter, object>> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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