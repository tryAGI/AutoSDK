//HintName: G.Models.FilterGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterGroup
    {
        /// <summary>
        /// Type of conjunction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conjunction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Conjunction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Filter> Filters { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroup" /> class.
        /// </summary>
        /// <param name="conjunction">
        /// Type of conjunction
        /// </param>
        /// <param name="filters"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterGroup(
            string conjunction,
            global::System.Collections.Generic.IList<global::G.Filter> filters,
            int id = default!)
        {
            this.Conjunction = conjunction ?? throw new global::System.ArgumentNullException(nameof(conjunction));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroup" /> class.
        /// </summary>
        public FilterGroup()
        {
        }
    }
}