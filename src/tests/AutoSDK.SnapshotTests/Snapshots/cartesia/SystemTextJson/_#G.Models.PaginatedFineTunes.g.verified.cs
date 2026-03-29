//HintName: G.Models.PaginatedFineTunes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of fine-tunes
    /// </summary>
    public sealed partial class PaginatedFineTunes
    {
        /// <summary>
        /// List of fine-tune objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FineTune> Data { get; set; }

        /// <summary>
        /// Whether there are more fine-tunes available
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
        /// Initializes a new instance of the <see cref="PaginatedFineTunes" /> class.
        /// </summary>
        /// <param name="data">
        /// List of fine-tune objects
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more fine-tunes available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedFineTunes(
            global::System.Collections.Generic.IList<global::G.FineTune> data,
            bool hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedFineTunes" /> class.
        /// </summary>
        public PaginatedFineTunes()
        {
        }
    }
}