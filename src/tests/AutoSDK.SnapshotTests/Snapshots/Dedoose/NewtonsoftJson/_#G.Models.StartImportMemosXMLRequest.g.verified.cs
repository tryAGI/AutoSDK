//HintName: G.Models.StartImportMemosXMLRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartImportMemosXMLRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportMemosXMLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        public StartImportMemosXMLRequest(
            global::System.Guid projectId,
            string fileURI)
        {
            this.ProjectId = projectId;
            this.FileURI = fileURI ?? throw new global::System.ArgumentNullException(nameof(fileURI));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportMemosXMLRequest" /> class.
        /// </summary>
        public StartImportMemosXMLRequest()
        {
        }
    }
}