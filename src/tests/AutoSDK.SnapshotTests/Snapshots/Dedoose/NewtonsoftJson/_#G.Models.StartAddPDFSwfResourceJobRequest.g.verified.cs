//HintName: G.Models.StartAddPDFSwfResourceJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartAddPDFSwfResourceJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileUri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFSwfResourceJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="fileUri"></param>
        public StartAddPDFSwfResourceJobRequest(
            global::System.Guid projectId,
            string title,
            string fileUri)
        {
            this.ProjectId = projectId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.FileUri = fileUri ?? throw new global::System.ArgumentNullException(nameof(fileUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartAddPDFSwfResourceJobRequest" /> class.
        /// </summary>
        public StartAddPDFSwfResourceJobRequest()
        {
        }
    }
}