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
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Logs { get; set; } = default!;

        /// <summary>
        /// Build logs structured<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logEntries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BuildLogEntry> LogEntries { get; set; } = default!;

        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Identifier of the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildID", Required = global::Newtonsoft.Json.Required.Always)]
        public string BuildID { get; set; } = default!;

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateBuildStatusJsonConverter))]
        public global::G.TemplateBuildStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public global::G.BuildStatusReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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