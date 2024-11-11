//HintName: G.Models.PageBuildStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page Build Status
    /// </summary>
    public sealed partial class PageBuildStatus
    {
        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/pages/builds/latest
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/pages/builds/latest</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBuildStatus" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/pages/builds/latest
        /// </param>
        /// <param name="status">
        /// Example: queued
        /// </param>
        public PageBuildStatus(
            string url,
            string status)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBuildStatus" /> class.
        /// </summary>
        public PageBuildStatus()
        {
        }
    }
}