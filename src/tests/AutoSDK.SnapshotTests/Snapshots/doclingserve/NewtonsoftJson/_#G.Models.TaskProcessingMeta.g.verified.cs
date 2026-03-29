//HintName: G.Models.TaskProcessingMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskProcessingMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_docs", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumDocs { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_processed")]
        public int? NumProcessed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_succeeded")]
        public int? NumSucceeded { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_failed")]
        public int? NumFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProcessingMeta" /> class.
        /// </summary>
        /// <param name="numDocs"></param>
        /// <param name="numProcessed">
        /// Default Value: 0
        /// </param>
        /// <param name="numSucceeded">
        /// Default Value: 0
        /// </param>
        /// <param name="numFailed">
        /// Default Value: 0
        /// </param>
        public TaskProcessingMeta(
            int numDocs,
            int? numProcessed,
            int? numSucceeded,
            int? numFailed)
        {
            this.NumDocs = numDocs;
            this.NumProcessed = numProcessed;
            this.NumSucceeded = numSucceeded;
            this.NumFailed = numFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProcessingMeta" /> class.
        /// </summary>
        public TaskProcessingMeta()
        {
        }
    }
}