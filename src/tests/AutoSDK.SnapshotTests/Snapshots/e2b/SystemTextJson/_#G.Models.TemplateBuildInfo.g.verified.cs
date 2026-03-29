//HintName: G.Models.TemplateBuildInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildInfo
    {
        /// <summary>
        /// Build logs<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Logs { get; set; }

        /// <summary>
        /// Build logs structured<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logEntries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BuildLogEntry> LogEntries { get; set; }

        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Identifier of the build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildID { get; set; }

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplateBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateBuildStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public global::G.BuildStatusReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildInfo" /> class.
        /// </summary>
        /// <param name="logs">
        /// Build logs<br/>
        /// Default Value: []
        /// </param>
        /// <param name="logEntries">
        /// Build logs structured<br/>
        /// Default Value: []
        /// </param>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="buildID">
        /// Identifier of the build
        /// </param>
        /// <param name="status">
        /// Status of the template build
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBuildInfo(
            global::System.Collections.Generic.IList<string> logs,
            global::System.Collections.Generic.IList<global::G.BuildLogEntry> logEntries,
            string templateID,
            string buildID,
            global::G.TemplateBuildStatus status,
            global::G.BuildStatusReason? reason)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.LogEntries = logEntries ?? throw new global::System.ArgumentNullException(nameof(logEntries));
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.BuildID = buildID ?? throw new global::System.ArgumentNullException(nameof(buildID));
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildInfo" /> class.
        /// </summary>
        public TemplateBuildInfo()
        {
        }
    }
}