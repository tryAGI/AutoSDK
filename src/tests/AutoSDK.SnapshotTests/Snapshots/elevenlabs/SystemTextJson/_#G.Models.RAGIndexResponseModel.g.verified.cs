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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RAGIndexStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RAGIndexStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProgressPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGIndexResponseModel" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="progressPercentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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