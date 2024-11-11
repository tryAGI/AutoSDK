//HintName: G.Models.TrainingFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingFile" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TrainingFile(
            global::System.Guid fileId,
            double? weight)
        {
            this.FileId = fileId;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingFile" /> class.
        /// </summary>
        public TrainingFile()
        {
        }
    }
}