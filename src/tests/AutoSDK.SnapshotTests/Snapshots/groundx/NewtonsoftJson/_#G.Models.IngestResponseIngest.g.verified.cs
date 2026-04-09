//HintName: G.Models.IngestResponseIngest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestResponseIngest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProcessId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProcessingStatusJsonConverter))]
        public global::G.ProcessingStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponseIngest" /> class.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="status"></param>
        public IngestResponseIngest(
            global::System.Guid processId,
            global::G.ProcessingStatus status)
        {
            this.ProcessId = processId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponseIngest" /> class.
        /// </summary>
        public IngestResponseIngest()
        {
        }
    }
}