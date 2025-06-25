//HintName: G.Models.ListComponentDefinitionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListComponentDefinitionsResponse contains a list of component definitions.
    /// </summary>
    public sealed partial class ListComponentDefinitionsResponse
    {
        /// <summary>
        /// A list of component definition resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("componentDefinitions")]
        public global::System.Collections.Generic.IList<global::G.ComponentDefinition>? ComponentDefinitions { get; set; }

        /// <summary>
        /// Total number of component definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="componentDefinitions">
        /// A list of component definition resources.
        /// </param>
        /// <param name="totalSize">
        /// Total number of component definitions.
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.
        /// </param>
        /// <param name="page">
        /// The requested page offset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListComponentDefinitionsResponse(
            global::System.Collections.Generic.IList<global::G.ComponentDefinition>? componentDefinitions,
            int? totalSize,
            int? pageSize,
            int? page)
        {
            this.ComponentDefinitions = componentDefinitions;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComponentDefinitionsResponse" /> class.
        /// </summary>
        public ListComponentDefinitionsResponse()
        {
        }
    }
}