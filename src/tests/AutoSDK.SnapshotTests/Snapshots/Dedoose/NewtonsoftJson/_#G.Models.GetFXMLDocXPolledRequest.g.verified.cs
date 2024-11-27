//HintName: G.Models.GetFXMLDocXPolledRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFXMLDocXPolledRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileURL", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileURL { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFXMLDocXPolledRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURL"></param>
        public GetFXMLDocXPolledRequest(
            global::System.Guid projectId,
            string fileURL)
        {
            this.ProjectId = projectId;
            this.FileURL = fileURL ?? throw new global::System.ArgumentNullException(nameof(fileURL));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFXMLDocXPolledRequest" /> class.
        /// </summary>
        public GetFXMLDocXPolledRequest()
        {
        }
    }
}