//HintName: G.Models.FilterGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterGroupRequest
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
        public required global::System.Collections.Generic.IList<global::G.FilterRequest> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroupRequest" /> class.
        /// </summary>
        /// <param name="conjunction">
        /// Type of conjunction
        /// </param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterGroupRequest(
            string conjunction,
            global::System.Collections.Generic.IList<global::G.FilterRequest> filters)
        {
            this.Conjunction = conjunction ?? throw new global::System.ArgumentNullException(nameof(conjunction));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroupRequest" /> class.
        /// </summary>
        public FilterGroupRequest()
        {
        }
    }
}