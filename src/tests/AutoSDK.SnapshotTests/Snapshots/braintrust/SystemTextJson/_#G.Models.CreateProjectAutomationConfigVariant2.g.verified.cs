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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter))]
        public global::G.CreateProjectAutomationConfigVariant2EventType EventType { get; set; }

        /// <summary>
        /// The definition of what to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3> ExportDefinition { get; set; }

        /// <summary>
        /// The path to export the results to. It should include the storage protocol and prefix, e.g. s3://bucket-name/path/to/export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportPath { get; set; }

        /// <summary>
        /// The format to export the results in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateProjectAutomationConfigVariant2Format Format { get; set; }

        /// <summary>
        /// Perform the triggered action at most once in this interval of seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IntervalSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateProjectAutomationConfigVariant2Credentials Credentials { get; set; }

        /// <summary>
        /// The number of rows to export in each batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public double? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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