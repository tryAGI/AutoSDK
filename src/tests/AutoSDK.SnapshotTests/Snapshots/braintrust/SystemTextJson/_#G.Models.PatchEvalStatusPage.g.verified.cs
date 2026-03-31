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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the eval status page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the logo to display on the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// The theme for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalStatusPageThemeJsonConverter))]
        public global::G.EvalStatusPageTheme? Theme { get; set; }

        /// <summary>
        /// Configuration for what data to display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.EvalStatusPageConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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