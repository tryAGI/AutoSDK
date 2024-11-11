//HintName: G.Models.SampleResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        /// <param name="sampleId"></param>
        /// <param name="fileName"></param>
        /// <param name="mimeType"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="hash"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SampleResponseModel(
            string sampleId,
            string fileName,
            string mimeType,
            int sizeBytes,
            string hash)
        {
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        public SampleResponseModel()
        {
        }
    }
}