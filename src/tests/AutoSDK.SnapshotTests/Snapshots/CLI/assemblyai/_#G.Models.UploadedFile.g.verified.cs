//HintName: G.Models.UploadedFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedFile
    {
        /// <summary>
        /// A URL that points to your audio file, accessible only by AssemblyAI's servers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFile" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// A URL that points to your audio file, accessible only by AssemblyAI's servers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedFile(
            string uploadUrl)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFile" /> class.
        /// </summary>
        public UploadedFile()
        {
        }
    }
}