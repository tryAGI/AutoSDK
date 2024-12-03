//HintName: G.Models.RunStepDetailsToolCallsCodeOutputImageObjectImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObjectImage
    {
        /// <summary>
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObjectImage" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </param>
        public RunStepDetailsToolCallsCodeOutputImageObjectImage(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObjectImage" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputImageObjectImage()
        {
        }
    }
}