//HintName: G.Models.Web.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chunk from the web.
    /// </summary>
    public sealed partial class Web
    {
        /// <summary>
        /// Output only. URI reference of the chunk.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Output only. Title of the chunk.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        /// <param name="uri">
        /// Output only. URI reference of the chunk.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Output only. Title of the chunk.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Web(
            string? uri,
            string? title)
        {
            this.Uri = uri;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        public Web()
        {
        }
    }
}