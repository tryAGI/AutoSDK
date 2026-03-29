//HintName: G.Models.PatchEvalStatusPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchEvalStatusPage
    {
        /// <summary>
        /// Name of the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the logo to display on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// The theme for the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("theme")]
        public global::G.EvalStatusPageTheme? Theme { get; set; }

        /// <summary>
        /// Configuration for what data to display
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.EvalStatusPageConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEvalStatusPage" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the eval status page
        /// </param>
        /// <param name="description">
        /// Textual description of the eval status page
        /// </param>
        /// <param name="logoUrl">
        /// URL of the logo to display on the page
        /// </param>
        /// <param name="theme">
        /// The theme for the page
        /// </param>
        /// <param name="config">
        /// Configuration for what data to display
        /// </param>
        public PatchEvalStatusPage(
            string? name,
            string? description,
            string? logoUrl,
            global::G.EvalStatusPageTheme? theme,
            global::G.EvalStatusPageConfig? config)
        {
            this.Name = name;
            this.Description = description;
            this.LogoUrl = logoUrl;
            this.Theme = theme;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchEvalStatusPage" /> class.
        /// </summary>
        public PatchEvalStatusPage()
        {
        }
    }
}