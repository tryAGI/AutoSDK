//HintName: G.Models.FileUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileUpload
    {
        /// <summary>
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG</example>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Example: image
        /// </summary>
        /// <example>image</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: image.png
        /// </summary>
        /// <example>image.png</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::Newtonsoft.Json.JsonProperty("mime")]
        public string? Mime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUpload" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </param>
        /// <param name="type">
        /// Example: image
        /// </param>
        /// <param name="name">
        /// Example: image.png
        /// </param>
        /// <param name="mime">
        /// Example: image/png
        /// </param>
        public FileUpload(
            string? data,
            string? type,
            string? name,
            string? mime)
        {
            this.Data = data;
            this.Type = type;
            this.Name = name;
            this.Mime = mime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUpload" /> class.
        /// </summary>
        public FileUpload()
        {
        }
    }
}