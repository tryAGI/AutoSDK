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
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_step")]
        public int? CheckpointStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinetuneDownloadResultObjectJsonConverter))]
        public global::G.FinetuneDownloadResultObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDownloadResult" /> class.
        /// </summary>
        /// <param name="checkpointStep"></param>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="size"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FinetuneDownloadResult(
            int? checkpointStep,
            string? filename,
            string? id,
            global::G.FinetuneDownloadResultObject? @object,
            int? size)
        {
            this.CheckpointStep = checkpointStep;
            this.Filename = filename;
            this.Id = id;
            this.Object = @object;
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