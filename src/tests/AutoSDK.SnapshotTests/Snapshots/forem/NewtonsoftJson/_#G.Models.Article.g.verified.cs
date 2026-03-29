//HintName: G.Models.Article.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an Article to be created/updated
    /// </summary>
    public sealed partial class Article
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("article")]
        public global::G.ArticleArticle1? Article1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class.
        /// </summary>
        /// <param name="article1"></param>
        public Article(
            global::G.ArticleArticle1? article1)
        {
            this.Article1 = article1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Article" /> class.
        /// </summary>
        public Article()
        {
        }
    }
}