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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObjectImage" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The [file](/docs/api-reference/files) ID of the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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