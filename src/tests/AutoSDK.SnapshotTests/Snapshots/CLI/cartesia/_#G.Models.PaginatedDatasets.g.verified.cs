//HintName: G.Models.PaginatedDatasets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of datasets
    /// </summary>
    public sealed partial class PaginatedDatasets
    {
        /// <summary>
        /// List of dataset objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Dataset> Data { get; set; }

        /// <summary>
        /// Whether there are more datasets available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedDatasets" /> class.
        /// </summary>
        /// <param name="data">
        /// List of dataset objects
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more datasets available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedDatasets(
            global::System.Collections.Generic.IList<global::G.Dataset> data,
            bool hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedDatasets" /> class.
        /// </summary>
        public PaginatedDatasets()
        {
        }
    }
}