//HintName: G.Models.ProcessStatusResponseIngestProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessStatusResponseIngestProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        public global::G.ProcessStatusResponseIngestProgressCancelled? Cancelled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete")]
        public global::G.ProcessStatusResponseIngestProgressComplete? Complete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::G.ProcessStatusResponseIngestProgressErrors? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        public global::G.ProcessStatusResponseIngestProgressProcessing? Processing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngestProgress" /> class.
        /// </summary>
        /// <param name="cancelled"></param>
        /// <param name="complete"></param>
        /// <param name="errors"></param>
        /// <param name="processing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessStatusResponseIngestProgress(
            global::G.ProcessStatusResponseIngestProgressCancelled? cancelled,
            global::G.ProcessStatusResponseIngestProgressComplete? complete,
            global::G.ProcessStatusResponseIngestProgressErrors? errors,
            global::G.ProcessStatusResponseIngestProgressProcessing? processing)
        {
            this.Cancelled = cancelled;
            this.Complete = complete;
            this.Errors = errors;
            this.Processing = processing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngestProgress" /> class.
        /// </summary>
        public ProcessStatusResponseIngestProgress()
        {
        }
    }
}