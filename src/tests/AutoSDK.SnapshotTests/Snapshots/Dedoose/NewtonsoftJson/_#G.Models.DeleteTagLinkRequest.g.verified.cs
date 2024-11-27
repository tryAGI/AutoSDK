//HintName: G.Models.DeleteTagLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTagLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentProjectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TagLink Link { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagLinkRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="link"></param>
        public DeleteTagLinkRequest(
            global::System.Guid currentProjectId,
            global::G.TagLink link)
        {
            this.CurrentProjectId = currentProjectId;
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTagLinkRequest" /> class.
        /// </summary>
        public DeleteTagLinkRequest()
        {
        }
    }
}