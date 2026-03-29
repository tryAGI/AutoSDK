//HintName: G.Models.PaginatedVoices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated list of voices created from a fine-tune
    /// </summary>
    public sealed partial class PaginatedVoices
    {
        /// <summary>
        /// List of voice objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Voice> Data { get; set; } = default!;

        /// <summary>
        /// Whether there are more voices available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedVoices" /> class.
        /// </summary>
        /// <param name="data">
        /// List of voice objects
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more voices available
        /// </param>
        public PaginatedVoices(
            global::System.Collections.Generic.IList<global::G.Voice> data,
            bool hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedVoices" /> class.
        /// </summary>
        public PaginatedVoices()
        {
        }
    }
}