//HintName: G.Models.Comment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Comment on an Article or Podcast Episode
    /// </summary>
    public sealed partial class Comment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_code")]
        public string? IdCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Podcast image url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="idCode"></param>
        /// <param name="createdAt"></param>
        /// <param name="imageUrl">
        /// Podcast image url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Comment(
            string? typeOf,
            string? idCode,
            global::System.DateTime? createdAt,
            string? imageUrl)
        {
            this.TypeOf = typeOf;
            this.IdCode = idCode;
            this.CreatedAt = createdAt;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        public Comment()
        {
        }
    }
}