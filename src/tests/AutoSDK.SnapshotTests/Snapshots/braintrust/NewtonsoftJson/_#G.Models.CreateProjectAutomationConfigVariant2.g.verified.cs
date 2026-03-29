//HintName: G.Models.CreateProjectAutomationConfigVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant2
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.CreateProjectAutomationConfigVariant2EventType EventType { get; set; }

        /// <summary>
        /// The definition of what to export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_definition", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3> ExportDefinition { get; set; } = default!;

        /// <summary>
        /// The path to export the results to. It should include the storage protocol and prefix, e.g. s3://bucket-name/path/to/export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportPath { get; set; } = default!;

        /// <summary>
        /// The format to export the results in
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateProjectAutomationConfigVariant2Format Format { get; set; } = default!;

        /// <summary>
        /// Perform the triggered action at most once in this interval of seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double IntervalSeconds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentials", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateProjectAutomationConfigVariant2Credentials Credentials { get; set; } = default!;

        /// <summary>
        /// The number of rows to export in each batch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant2" /> class.
        /// </summary>
        /// <param name="exportDefinition">
        /// The definition of what to export
        /// </param>
        /// <param name="exportPath">
        /// The path to export the results to. It should include the storage protocol and prefix, e.g. s3://bucket-name/path/to/export
        /// </param>
        /// <param name="format">
        /// The format to export the results in
        /// </param>
        /// <param name="intervalSeconds">
        /// Perform the triggered action at most once in this interval of seconds
        /// </param>
        /// <param name="credentials"></param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="batchSize">
        /// The number of rows to export in each batch
        /// </param>
        public CreateProjectAutomationConfigVariant2(
            global::G.OneOf<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3> exportDefinition,
            string exportPath,
            global::G.CreateProjectAutomationConfigVariant2Format format,
            double intervalSeconds,
            global::G.CreateProjectAutomationConfigVariant2Credentials credentials,
            global::G.CreateProjectAutomationConfigVariant2EventType eventType,
            double? batchSize)
        {
            this.EventType = eventType;
            this.ExportDefinition = exportDefinition;
            this.ExportPath = exportPath ?? throw new global::System.ArgumentNullException(nameof(exportPath));
            this.Format = format;
            this.IntervalSeconds = intervalSeconds;
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant2" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant2()
        {
        }
    }
}