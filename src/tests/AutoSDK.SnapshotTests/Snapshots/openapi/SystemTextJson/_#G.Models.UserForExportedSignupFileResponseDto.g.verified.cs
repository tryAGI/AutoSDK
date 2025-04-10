//HintName: G.Models.UserForExportedSignupFileResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForExportedSignupFileResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signedupUserExportFileName")]
        public string? SignedupUserExportFileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileBytes")]
        public byte[]? FileBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForExportedSignupFileResponseDto" /> class.
        /// </summary>
        /// <param name="signedupUserExportFileName"></param>
        /// <param name="contentType"></param>
        /// <param name="fileBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForExportedSignupFileResponseDto(
            string? signedupUserExportFileName,
            string? contentType,
            byte[]? fileBytes)
        {
            this.SignedupUserExportFileName = signedupUserExportFileName;
            this.ContentType = contentType;
            this.FileBytes = fileBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForExportedSignupFileResponseDto" /> class.
        /// </summary>
        public UserForExportedSignupFileResponseDto()
        {
        }
    }
}