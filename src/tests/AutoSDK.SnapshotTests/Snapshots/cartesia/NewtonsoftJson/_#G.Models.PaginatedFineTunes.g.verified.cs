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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FineTune> Data { get; set; } = default!;

        /// <summary>
        /// Whether there are more fine-tunes available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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