//HintName: G.Models.WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation" /> class.
        /// </summary>
        /// <param name="endColumn"></param>
        /// <param name="endLine"></param>
        /// <param name="path"></param>
        /// <param name="startColumn"></param>
        /// <param name="startLine"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation(
            int? endColumn,
            int? endLine,
            string? path,
            int? startColumn,
            int? startLine)
        {
            this.EndColumn = endColumn;
            this.EndLine = endLine;
            this.Path = path;
            this.StartColumn = startColumn;
            this.StartLine = startLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation" /> class.
        /// </summary>
        public WebhookCodeScanningAlertReopenedByUserAlertMostRecentInstanceLocation()
        {
        }
    }
}