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
        [global::System.Text.Json.Serialization.JsonPropertyName("num_docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDocs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_processed")]
        public int? NumProcessed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_succeeded")]
        public int? NumSucceeded { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_failed")]
        public int? NumFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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