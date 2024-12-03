//HintName: G.Models.StoreProjectFileStringRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreProjectFileStringRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileStorageType", Required = global::Newtonsoft.Json.Required.Always)]
        public int FileStorageType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension", Required = global::Newtonsoft.Json.Required.Always)]
        public string Extension { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreProjectFileStringRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileStorageType"></param>
        /// <param name="extension"></param>
        /// <param name="text"></param>
        public StoreProjectFileStringRequest(
            global::System.Guid projectId,
            int fileStorageType,
            string extension,
            string text)
        {
            this.ProjectId = projectId;
            this.FileStorageType = fileStorageType;
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreProjectFileStringRequest" /> class.
        /// </summary>
        public StoreProjectFileStringRequest()
        {
        }
    }
}