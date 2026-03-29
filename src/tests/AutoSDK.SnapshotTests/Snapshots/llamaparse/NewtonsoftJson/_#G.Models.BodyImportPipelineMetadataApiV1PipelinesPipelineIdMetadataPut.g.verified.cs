//HintName: G.Models.BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] UploadFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut" /> class.
        /// </summary>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        public BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut(
            byte[] uploadFile,
            string uploadFilename)
        {
            this.UploadFile = uploadFile ?? throw new global::System.ArgumentNullException(nameof(uploadFile));
            this.UploadFilename = uploadFilename ?? throw new global::System.ArgumentNullException(nameof(uploadFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut" /> class.
        /// </summary>
        public BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut()
        {
        }
    }
}