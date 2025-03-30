//HintName: G.Models.BulkExportRunMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRunMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prefix { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.BulkExportRunProgress? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunMetadata" /> class.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="result"></param>
        public BulkExportRunMetadata(
            string prefix,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.BulkExportRunProgress? result)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunMetadata" /> class.
        /// </summary>
        public BulkExportRunMetadata()
        {
        }
    }
}