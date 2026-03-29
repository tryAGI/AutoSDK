//HintName: G.Models.ImageRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ImageRef.
    /// </summary>
    public sealed partial class ImageRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimetype", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mimetype { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dpi", Required = global::Newtonsoft.Json.Required.Always)]
        public int Dpi { get; set; } = default!;

        /// <summary>
        /// Size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Size Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        /// <param name="mimetype"></param>
        /// <param name="dpi"></param>
        /// <param name="size">
        /// Size.
        /// </param>
        /// <param name="uri"></param>
        public ImageRef(
            string mimetype,
            int dpi,
            global::G.Size size,
            string uri)
        {
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.Dpi = dpi;
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        public ImageRef()
        {
        }
    }
}