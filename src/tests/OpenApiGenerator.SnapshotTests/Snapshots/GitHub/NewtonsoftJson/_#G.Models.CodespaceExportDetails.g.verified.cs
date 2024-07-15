//HintName: G.Models.CodespaceExportDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An export of a codespace. Also, latest export details for a codespace can be fetched with id = latest
    /// </summary>
    public sealed partial class CodespaceExportDetails
    {
        /// <summary>
        /// State of the latest export<br/>
        /// Example: succeeded | failed | in_progress
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Completion time of the last export operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Name of the exported branch<br/>
        /// Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Git commit SHA of the exported branch<br/>
        /// Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Id for the export details<br/>
        /// Example: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Url for fetching export details<br/>
        /// Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_url")]
        public string? ExportUrl { get; set; }

        /// <summary>
        /// Web url for the exported branch<br/>
        /// Example: https://github.com/octocat/hello-world/tree/:branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}