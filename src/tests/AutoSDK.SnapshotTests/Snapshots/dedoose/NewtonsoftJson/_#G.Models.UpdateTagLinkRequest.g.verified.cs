//HintName: G.Models.UpdateTagLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTagLinkRequest
    {
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
        /// Initializes a new instance of the <see cref="UpdateTagLinkRequest" /> class.
        /// </summary>
        /// <param name="link"></param>
        public UpdateTagLinkRequest(
            global::G.TagLink link)
        {
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagLinkRequest" /> class.
        /// </summary>
        public UpdateTagLinkRequest()
        {
        }
    }
}