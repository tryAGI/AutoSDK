//HintName: G.Models.StartProjectImportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartProjectImportJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileURI", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileURI { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password", Required = global::Newtonsoft.Json.Required.Always)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectImportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="password"></param>
        public StartProjectImportJobRequest(
            global::System.Guid projectId,
            string fileURI,
            string password)
        {
            this.ProjectId = projectId;
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartProjectImportJobRequest" /> class.
        /// </summary>
        public StartProjectImportJobRequest()
        {
        }
    }
}