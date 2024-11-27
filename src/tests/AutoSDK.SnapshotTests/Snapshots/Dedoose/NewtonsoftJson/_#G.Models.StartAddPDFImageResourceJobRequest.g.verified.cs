//HintName: G.Models.StartAddPDFImageResourceJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartAddPDFImageResourceJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileURI", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileURI { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFImageResourceJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fileName"></param>
        /// <param name="fileURI"></param>
        public StartAddPDFImageResourceJobRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            string fileName,
            string fileURI)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFImageResourceJobRequest" /> class.
        /// </summary>
        public StartAddPDFImageResourceJobRequest()
        {
        }
    }
}