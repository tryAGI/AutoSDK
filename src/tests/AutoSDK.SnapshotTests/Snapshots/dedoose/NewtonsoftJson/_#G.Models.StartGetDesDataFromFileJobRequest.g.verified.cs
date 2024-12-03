//HintName: G.Models.StartGetDesDataFromFileJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartGetDesDataFromFileJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("localFileURL", Required = global::Newtonsoft.Json.Required.Always)]
        public string LocalFileURL { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetDesDataFromFileJobRequest" /> class.
        /// </summary>
        /// <param name="localFileURL"></param>
        /// <param name="setId"></param>
        /// <param name="projectId"></param>
        public StartGetDesDataFromFileJobRequest(
            string localFileURL,
            global::System.Guid setId,
            global::System.Guid projectId)
        {
            this.LocalFileURL = localFileURL ?? throw new global::System.ArgumentNullException(nameof(localFileURL));
            this.SetId = setId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetDesDataFromFileJobRequest" /> class.
        /// </summary>
        public StartGetDesDataFromFileJobRequest()
        {
        }
    }
}