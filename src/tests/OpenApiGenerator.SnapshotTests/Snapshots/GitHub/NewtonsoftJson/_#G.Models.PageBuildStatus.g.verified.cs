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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: queued
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}