//HintName: G.Models.PatchByFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The patch and filter specifying which documents to patch.
    /// </summary>
    public sealed partial class PatchByFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Patch { get; set; }

        /// <summary>
        /// Filter by attributes. Same syntax as the query endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchByFilter" /> class.
        /// </summary>
        /// <param name="patch"></param>
        /// <param name="filters">
        /// Filter by attributes. Same syntax as the query endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchByFilter(
            object patch,
            object filters)
        {
            this.Patch = patch ?? throw new global::System.ArgumentNullException(nameof(patch));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchByFilter" /> class.
        /// </summary>
        public PatchByFilter()
        {
        }
    }
}