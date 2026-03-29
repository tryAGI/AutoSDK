//HintName: G.Models.CreatePagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePagesRequest
    {
        /// <summary>
        /// Title of the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// For internal use, helps similar pages from one another
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_markdown")]
        public string? BodyMarkdown { get; set; }

        /// <summary>
        /// For JSON pages, the JSON body
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_json")]
        public string? BodyJson { get; set; }

        /// <summary>
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_top_level_path")]
        public bool? IsTopLevelPath { get; set; }

        /// <summary>
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::G.CreatePagesRequestTemplate? Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePagesRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the page
        /// </param>
        /// <param name="slug">
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </param>
        /// <param name="description">
        /// For internal use, helps similar pages from one another
        /// </param>
        /// <param name="bodyMarkdown">
        /// The text (in markdown) of the ad (required)
        /// </param>
        /// <param name="bodyJson">
        /// For JSON pages, the JSON body
        /// </param>
        /// <param name="isTopLevelPath">
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </param>
        /// <param name="template">
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </param>
        public CreatePagesRequest(
            string? title,
            string? slug,
            string? description,
            string? bodyMarkdown,
            string? bodyJson,
            bool? isTopLevelPath,
            global::G.CreatePagesRequestTemplate? template)
        {
            this.Title = title;
            this.Slug = slug;
            this.Description = description;
            this.BodyMarkdown = bodyMarkdown;
            this.BodyJson = bodyJson;
            this.IsTopLevelPath = isTopLevelPath;
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePagesRequest" /> class.
        /// </summary>
        public CreatePagesRequest()
        {
        }
    }
}