//HintName: G.Models.ArticleArticle1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArticleArticle1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_markdown")]
        public string? BodyMarkdown { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("series")]
        public string? Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("main_image")]
        public string? MainImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canonical_url")]
        public string? CanonicalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleArticle1" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="bodyMarkdown"></param>
        /// <param name="published">
        /// Default Value: false
        /// </param>
        /// <param name="series"></param>
        /// <param name="mainImage"></param>
        /// <param name="canonicalUrl"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="organizationId"></param>
        public ArticleArticle1(
            string? title,
            string? bodyMarkdown,
            bool? published,
            string? series,
            string? mainImage,
            string? canonicalUrl,
            string? description,
            string? tags,
            int? organizationId)
        {
            this.Title = title;
            this.BodyMarkdown = bodyMarkdown;
            this.Published = published;
            this.Series = series;
            this.MainImage = mainImage;
            this.CanonicalUrl = canonicalUrl;
            this.Description = description;
            this.Tags = tags;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleArticle1" /> class.
        /// </summary>
        public ArticleArticle1()
        {
        }
    }
}