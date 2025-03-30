//HintName: G.Models.RAGIndexResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGIndexResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RAGIndexStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProgressPercentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="progressPercentage"></param>
        public RAGIndexResponseModel(
            global::G.RAGIndexStatus status,
            double progressPercentage)
        {
            this.Status = status;
            this.ProgressPercentage = progressPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexResponseModel" /> class.
        /// </summary>
        public RAGIndexResponseModel()
        {
        }
    }
}