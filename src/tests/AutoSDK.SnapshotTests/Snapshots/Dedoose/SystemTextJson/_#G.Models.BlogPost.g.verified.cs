//HintName: G.Models.BlogPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlogPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postDate")]
        public string? PostDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPost" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="postDate"></param>
        /// <param name="summary"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BlogPost(
            string? title,
            string? postDate,
            string? summary,
            string? url)
        {
            this.Title = title;
            this.PostDate = postDate;
            this.Summary = summary;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPost" /> class.
        /// </summary>
        public BlogPost()
        {
        }
    }
}