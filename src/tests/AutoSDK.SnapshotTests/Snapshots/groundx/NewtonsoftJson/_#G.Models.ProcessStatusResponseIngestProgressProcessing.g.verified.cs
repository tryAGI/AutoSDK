//HintName: G.Models.ProcessStatusResponseIngestProgressProcessing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessStatusResponseIngestProgressProcessing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.DocumentDetail>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngestProgressProcessing" /> class.
        /// </summary>
        /// <param name="documents"></param>
        /// <param name="total"></param>
        public ProcessStatusResponseIngestProgressProcessing(
            global::System.Collections.Generic.IList<global::G.DocumentDetail>? documents,
            int? total)
        {
            this.Documents = documents;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessStatusResponseIngestProgressProcessing" /> class.
        /// </summary>
        public ProcessStatusResponseIngestProgressProcessing()
        {
        }
    }
}