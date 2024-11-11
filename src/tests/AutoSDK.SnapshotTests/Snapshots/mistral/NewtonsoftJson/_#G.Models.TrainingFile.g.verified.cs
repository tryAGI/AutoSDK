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
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingFile" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
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