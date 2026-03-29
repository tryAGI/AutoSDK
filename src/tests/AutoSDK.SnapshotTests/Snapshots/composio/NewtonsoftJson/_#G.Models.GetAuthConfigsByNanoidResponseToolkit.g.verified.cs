//HintName: G.Models.GetAuthConfigsByNanoidResponseToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the associated integration
    /// </summary>
    public sealed partial class GetAuthConfigsByNanoidResponseToolkit
    {
        /// <summary>
        /// The unique identifier of the integration app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The URL to the integration app's logo image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// URL to a guide page with authentication setup instructions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_guide_url")]
        public string? AuthGuideUrl { get; set; }

        /// <summary>
        /// URL to a page where users can obtain or configure credentials
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_hint_url")]
        public string? AuthHintUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// The unique identifier of the integration app
        /// </param>
        /// <param name="logo">
        /// The URL to the integration app's logo image
        /// </param>
        /// <param name="authGuideUrl">
        /// URL to a guide page with authentication setup instructions
        /// </param>
        /// <param name="authHintUrl">
        /// URL to a page where users can obtain or configure credentials
        /// </param>
        public GetAuthConfigsByNanoidResponseToolkit(
            string slug,
            string logo,
            string? authGuideUrl,
            string? authHintUrl)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
            this.AuthGuideUrl = authGuideUrl;
            this.AuthHintUrl = authHintUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseToolkit" /> class.
        /// </summary>
        public GetAuthConfigsByNanoidResponseToolkit()
        {
        }
    }
}