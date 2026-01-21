//HintName: G.Models.UploadedFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"upload_url":"https://cdn.assemblyai.com/upload/f756988d-47e2-4ca3-96ce-04bb168f8f2a"}
    /// </summary>
    public sealed partial class UploadedFile
    {
        /// <summary>
        /// A URL that points to your audio file, accessible only by AssemblyAI's servers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFile" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// A URL that points to your audio file, accessible only by AssemblyAI's servers
        /// </param>
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