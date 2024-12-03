//HintName: G.Models.BulkExportCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bulk_export_destination_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid BulkExportDestinationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.BulkExportFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compression")]
        public global::G.BulkExportCompression? Compression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportCreate" /> class.
        /// </summary>
        /// <param name="bulkExportDestinationId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="format"></param>
        /// <param name="compression"></param>
        public BulkExportCreate(
            global::System.Guid bulkExportDestinationId,
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.BulkExportFormat? format,
            global::G.BulkExportCompression? compression)
        {
            this.BulkExportDestinationId = bulkExportDestinationId;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Format = format;
            this.Compression = compression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportCreate" /> class.
        /// </summary>
        public BulkExportCreate()
        {
        }
    }
}