//HintName: G.Models.FinetuneDownloadResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneDownloadResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FinetuneDownloadResultObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checkpoint_step")]
        public int? CheckpointStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDownloadResult" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="id"></param>
        /// <param name="checkpointStep"></param>
        /// <param name="filename"></param>
        /// <param name="size"></param>
        public FinetuneDownloadResult(
            global::G.FinetuneDownloadResultObject? @object,
            string? id,
            int? checkpointStep,
            string? filename,
            int? size)
        {
            this.Object = @object;
            this.Id = id;
            this.CheckpointStep = checkpointStep;
            this.Filename = filename;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDownloadResult" /> class.
        /// </summary>
        public FinetuneDownloadResult()
        {
        }
    }
}