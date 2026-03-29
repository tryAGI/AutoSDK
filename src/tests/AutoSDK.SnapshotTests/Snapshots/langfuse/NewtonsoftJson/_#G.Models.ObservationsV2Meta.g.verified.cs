//HintName: G.Models.ObservationsV2Meta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for cursor-based pagination
    /// </summary>
    public sealed partial class ObservationsV2Meta
    {
        /// <summary>
        /// Base64-encoded cursor to use for retrieving the next page. If not present, there are no more results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Meta" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Base64-encoded cursor to use for retrieving the next page. If not present, there are no more results.
        /// </param>
        public ObservationsV2Meta(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Meta" /> class.
        /// </summary>
        public ObservationsV2Meta()
        {
        }
    }
}