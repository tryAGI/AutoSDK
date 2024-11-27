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
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TagLink Link { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagLinkRequest" /> class.
        /// </summary>
        /// <param name="link"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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