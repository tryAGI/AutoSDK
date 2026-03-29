//HintName: G.Models.PredictionUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionUpload
    {
        /// <summary>
        /// The type of file upload<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PredictionUploadType? Type { get; set; }

        /// <summary>
        /// The name of the file or resource<br/>
        /// Example: image.png
        /// </summary>
        /// <example>image.png</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The base64-encoded data or URL for the resource<br/>
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG</example>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The MIME type of the file or resource<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::Newtonsoft.Json.JsonProperty("mime")]
        public global::G.PredictionUploadMime? Mime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUpload" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of file upload<br/>
        /// Example: file
        /// </param>
        /// <param name="name">
        /// The name of the file or resource<br/>
        /// Example: image.png
        /// </param>
        /// <param name="data">
        /// The base64-encoded data or URL for the resource<br/>
        /// Example: data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS+2Vv0oDQRDG
        /// </param>
        /// <param name="mime">
        /// The MIME type of the file or resource<br/>
        /// Example: image/png
        /// </param>
        public PredictionUpload(
            global::G.PredictionUploadType? type,
            string? name,
            string? data,
            global::G.PredictionUploadMime? mime)
        {
            this.Type = type;
            this.Name = name;
            this.Data = data;
            this.Mime = mime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionUpload" /> class.
        /// </summary>
        public PredictionUpload()
        {
        }
    }
}