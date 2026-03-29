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
        [global::System.Text.Json.Serialization.JsonPropertyName("processId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProcessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProcessingStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProcessingStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponseIngest" /> class.
        /// </summary>
        /// <param name="processId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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