//HintName: G.Models.CreateUploadsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUploadsResponse
    {
        /// <summary>
        /// The URL to upload your media file to with a POST request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

        /// <summary>
        /// Fields that must be included in the file upload request as form data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; } = default!;

        /// <summary>
        /// The Runway upload URI to use in other API generation requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runwayUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunwayUri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadsResponse" /> class.
        /// </summary>
        /// <param name="uploadUrl">
        /// The URL to upload your media file to with a POST request.
        /// </param>
        /// <param name="fields">
        /// Fields that must be included in the file upload request as form data.
        /// </param>
        /// <param name="runwayUri">
        /// The Runway upload URI to use in other API generation requests
        /// </param>
        public CreateUploadsResponse(
            string uploadUrl,
            global::System.Collections.Generic.Dictionary<string, string> fields,
            string runwayUri)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.RunwayUri = runwayUri ?? throw new global::System.ArgumentNullException(nameof(runwayUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadsResponse" /> class.
        /// </summary>
        public CreateUploadsResponse()
        {
        }
    }
}