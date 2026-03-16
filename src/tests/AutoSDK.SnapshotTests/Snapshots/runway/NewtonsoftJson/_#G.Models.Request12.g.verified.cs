//HintName: G.Models.Request12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request12
    {
        /// <summary>
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The type of upload to create
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request12" /> class.
        /// </summary>
        /// <param name="filename">
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </param>
        /// <param name="type">
        /// The type of upload to create
        /// </param>
        public Request12(
            string filename,
            global::G.RequestType type)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request12" /> class.
        /// </summary>
        public Request12()
        {
        }
    }
}