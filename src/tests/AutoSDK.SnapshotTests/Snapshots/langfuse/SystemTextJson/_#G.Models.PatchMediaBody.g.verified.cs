//HintName: G.Models.PatchMediaBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchMediaBody
    {
        /// <summary>
        /// The date and time when the media record was uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UploadedAt { get; set; }

        /// <summary>
        /// The HTTP status code of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadHttpStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UploadHttpStatus { get; set; }

        /// <summary>
        /// The HTTP error message of the upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadHttpError")]
        public string? UploadHttpError { get; set; }

        /// <summary>
        /// The time in milliseconds it took to upload the media record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadTimeMs")]
        public int? UploadTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMediaBody" /> class.
        /// </summary>
        /// <param name="uploadedAt">
        /// The date and time when the media record was uploaded
        /// </param>
        /// <param name="uploadHttpStatus">
        /// The HTTP status code of the upload
        /// </param>
        /// <param name="uploadHttpError">
        /// The HTTP error message of the upload
        /// </param>
        /// <param name="uploadTimeMs">
        /// The time in milliseconds it took to upload the media record
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchMediaBody(
            global::System.DateTime uploadedAt,
            int uploadHttpStatus,
            string? uploadHttpError,
            int? uploadTimeMs)
        {
            this.UploadedAt = uploadedAt;
            this.UploadHttpStatus = uploadHttpStatus;
            this.UploadHttpError = uploadHttpError;
            this.UploadTimeMs = uploadTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchMediaBody" /> class.
        /// </summary>
        public PatchMediaBody()
        {
        }
    }
}