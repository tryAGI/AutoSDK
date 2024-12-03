//HintName: G.Models.BodyPatchImageV4PipelinesPipelineIdImagePatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPatchImageV4PipelinesPipelineIdImagePatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ImageFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchImageV4PipelinesPipelineIdImagePatch" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyPatchImageV4PipelinesPipelineIdImagePatch(
            byte[] imageFile,
            string imageFilename)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPatchImageV4PipelinesPipelineIdImagePatch" /> class.
        /// </summary>
        public BodyPatchImageV4PipelinesPipelineIdImagePatch()
        {
        }
    }
}