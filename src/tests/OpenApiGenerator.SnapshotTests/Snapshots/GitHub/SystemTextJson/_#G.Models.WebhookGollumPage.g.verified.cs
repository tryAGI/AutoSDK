//HintName: G.Models.WebhookGollumPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookGollumPage
    {
        /// <summary>
        /// The action that was performed on the page. Can be `created` or `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookGollumPageActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookGollumPageAction Action { get; set; }

        /// <summary>
        /// Points to the HTML wiki page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The name of the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageName { get; set; }

        /// <summary>
        /// The latest commit SHA of the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Summary { get; set; }

        /// <summary>
        /// The current page title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}