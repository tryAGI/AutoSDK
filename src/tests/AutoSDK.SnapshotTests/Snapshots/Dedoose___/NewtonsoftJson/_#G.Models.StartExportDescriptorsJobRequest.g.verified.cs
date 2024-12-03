//HintName: G.Models.StartExportDescriptorsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportDescriptorsJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> DescriptorIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileExtension { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportDescriptorsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="fileExtension"></param>
        public StartExportDescriptorsJobRequest(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorIds,
            string fileExtension)
        {
            this.ProjectId = projectId;
            this.SetId = setId;
            this.DescriptorIds = descriptorIds ?? throw new global::System.ArgumentNullException(nameof(descriptorIds));
            this.FileExtension = fileExtension ?? throw new global::System.ArgumentNullException(nameof(fileExtension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportDescriptorsJobRequest" /> class.
        /// </summary>
        public StartExportDescriptorsJobRequest()
        {
        }
    }
}