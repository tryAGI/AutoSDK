//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage
    {
        /// <summary>
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage(
            string? fileId)
        {
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage()
        {
        }
    }
}