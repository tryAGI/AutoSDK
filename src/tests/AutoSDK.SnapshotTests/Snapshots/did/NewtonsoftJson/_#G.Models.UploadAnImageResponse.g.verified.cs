//HintName: G.Models.UploadAnImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAnImageResponse
    {
        /// <summary>
        /// The temporary URL of the image.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// A unique identifier which represents this image operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("faces")]
        public global::System.Collections.Generic.IList<global::G.UploadAnImageResponseFace>? Faces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnImageResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// The temporary URL of the image.<br/>
        /// This URL should be provided when creating an animation via the /animations endpoint.
        /// </param>
        /// <param name="id">
        /// A unique identifier which represents this image operation
        /// </param>
        /// <param name="faces"></param>
        public UploadAnImageResponse(
            string url,
            string? id,
            global::System.Collections.Generic.IList<global::G.UploadAnImageResponseFace>? faces)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.Faces = faces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAnImageResponse" /> class.
        /// </summary>
        public UploadAnImageResponse()
        {
        }
    }
}