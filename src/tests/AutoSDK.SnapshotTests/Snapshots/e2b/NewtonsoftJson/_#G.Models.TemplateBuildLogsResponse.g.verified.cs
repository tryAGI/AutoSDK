//HintName: G.Models.TemplateBuildLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildLogsResponse
    {
        /// <summary>
        /// Build logs structured<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BuildLogEntry> Logs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildLogsResponse" /> class.
        /// </summary>
        /// <param name="logs">
        /// Build logs structured<br/>
        /// Default Value: []
        /// </param>
        public TemplateBuildLogsResponse(
            global::System.Collections.Generic.IList<global::G.BuildLogEntry> logs)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildLogsResponse" /> class.
        /// </summary>
        public TemplateBuildLogsResponse()
        {
        }
    }
}