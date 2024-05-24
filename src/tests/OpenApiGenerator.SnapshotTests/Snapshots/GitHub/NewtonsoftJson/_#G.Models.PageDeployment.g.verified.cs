//HintName: G.Models.PageDeployment.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public object Id { get; set; } = default!;

        /// <summary>
        /// The URI to monitor GitHub Pages deployment status.
        /// <br/>Example: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusUrl { get; set; } = default!;

        /// <summary>
        /// The URI to the deployed GitHub Pages.
        /// <br/>Example: hello-world.github.io
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PageUrl { get; set; } = default!;

        /// <summary>
        /// The URI to the deployed GitHub Pages preview.
        /// <br/>Example: monalisa-1231a2312sa32-23sda74.drafts.github.io
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}