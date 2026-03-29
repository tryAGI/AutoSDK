//HintName: G.Models.Page.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a page object
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// Title of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// For internal use, helps similar pages from one another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_markdown")]
        public string? BodyMarkdown { get; set; }

        /// <summary>
        /// For JSON pages, the JSON body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_json")]
        public string? BodyJson { get; set; }

        /// <summary>
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_top_level_path")]
        public bool? IsTopLevelPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_image")]
        public object? SocialImage { get; set; }

        /// <summary>
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </summary>
        /// <default>global::G.PageTemplate.Contained</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PageTemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PageTemplate Template { get; set; } = global::G.PageTemplate.Contained;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
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
        /// <param name="template">
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
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
        /// <param name="socialImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Page(
            string title,
            string slug,
            string description,
            global::G.PageTemplate template,
            string? bodyMarkdown,
            string? bodyJson,
            bool? isTopLevelPath,
            object? socialImage)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.BodyMarkdown = bodyMarkdown;
            this.BodyJson = bodyJson;
            this.IsTopLevelPath = isTopLevelPath;
            this.SocialImage = socialImage;
            this.Template = template;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        public Page()
        {
        }
    }
}