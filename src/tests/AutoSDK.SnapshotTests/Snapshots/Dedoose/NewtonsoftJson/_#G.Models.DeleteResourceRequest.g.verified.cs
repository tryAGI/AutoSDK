//HintName: G.Models.DeleteResourceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteResourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentProjectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Resource Resource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResourceRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="resource"></param>
        public DeleteResourceRequest(
            global::System.Guid currentProjectId,
            global::G.Resource resource)
        {
            this.CurrentProjectId = currentProjectId;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResourceRequest" /> class.
        /// </summary>
        public DeleteResourceRequest()
        {
        }
    }
}