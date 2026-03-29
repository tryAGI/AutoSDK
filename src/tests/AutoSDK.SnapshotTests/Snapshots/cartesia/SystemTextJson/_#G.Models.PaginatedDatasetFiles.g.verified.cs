//HintName: G.Models.PaginatedDatasetFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of files in a dataset
    /// </summary>
    public sealed partial class PaginatedDatasetFiles
    {
        /// <summary>
        /// List of file objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DatasetFile> Data { get; set; }

        /// <summary>
        /// Whether there are more files available
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
        /// Initializes a new instance of the <see cref="PaginatedDatasetFiles" /> class.
        /// </summary>
        /// <param name="data">
        /// List of file objects
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more files available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedDatasetFiles(
            global::System.Collections.Generic.IList<global::G.DatasetFile> data,
            bool hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedDatasetFiles" /> class.
        /// </summary>
        public PaginatedDatasetFiles()
        {
        }
    }
}