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
        /// State of the latest export
        /// <br/>Example: succeeded | failed | in_progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Completion time of the last export operation
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Name of the exported branch
        /// <br/>Example: codespace-monalisa-octocat-hello-world-g4wpq6h95q
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// Git commit SHA of the exported branch
        /// <br/>Example: fd95a81ca01e48ede9f39c799ecbcef817b8a3b2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Id for the export details
        /// <br/>Example: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Url for fetching export details
        /// <br/>Example: https://api.github.com/user/codespaces/:name/exports/latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_url")]
        public string? ExportUrl { get; set; }

        /// <summary>
        /// Web url for the exported branch
        /// <br/>Example: https://github.com/octocat/hello-world/tree/:branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}