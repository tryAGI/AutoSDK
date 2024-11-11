//HintName: G.Models.PageDeployment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The GitHub Pages deployment status.
    /// </summary>
    public sealed partial class PageDeployment
    {
        /// <summary>
        /// The ID of the GitHub Pages deployment. This is the Git SHA of the deployed commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<int?, string> Id { get; set; }

        /// <summary>
        /// The URI to monitor GitHub Pages deployment status.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusUrl { get; set; }

        /// <summary>
        /// The URI to the deployed GitHub Pages.<br/>
        /// Example: hello-world.github.io
        /// </summary>
        /// <example>hello-world.github.io</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PageUrl { get; set; }

        /// <summary>
        /// The URI to the deployed GitHub Pages preview.<br/>
        /// Example: monalisa-1231a2312sa32-23sda74.drafts.github.io
        /// </summary>
        /// <example>monalisa-1231a2312sa32-23sda74.drafts.github.io</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDeployment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the GitHub Pages deployment. This is the Git SHA of the deployed commit.
        /// </param>
        /// <param name="statusUrl">
        /// The URI to monitor GitHub Pages deployment status.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251
        /// </param>
        /// <param name="pageUrl">
        /// The URI to the deployed GitHub Pages.<br/>
        /// Example: hello-world.github.io
        /// </param>
        /// <param name="previewUrl">
        /// The URI to the deployed GitHub Pages preview.<br/>
        /// Example: monalisa-1231a2312sa32-23sda74.drafts.github.io
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PageDeployment(
            global::G.OneOf<int?, string> id,
            string statusUrl,
            string pageUrl,
            string? previewUrl)
        {
            this.Id = id;
            this.StatusUrl = statusUrl ?? throw new global::System.ArgumentNullException(nameof(statusUrl));
            this.PageUrl = pageUrl ?? throw new global::System.ArgumentNullException(nameof(pageUrl));
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDeployment" /> class.
        /// </summary>
        public PageDeployment()
        {
        }
    }
}