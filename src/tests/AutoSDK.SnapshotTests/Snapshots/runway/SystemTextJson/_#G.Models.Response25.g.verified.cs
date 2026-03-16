//HintName: G.Models.Response25.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response25
    {
        /// <summary>
        /// The URL to upload your media file to with a POST request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// Fields that must be included in the file upload request as form data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Fields { get; set; }

        /// <summary>
        /// The Runway upload URI to use in other API generation requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runwayUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunwayUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response25" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response25(
            string uploadUrl,
            global::System.Collections.Generic.Dictionary<string, string> fields,
            string runwayUri)
        {
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
            this.RunwayUri = runwayUri ?? throw new global::System.ArgumentNullException(nameof(runwayUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response25" /> class.
        /// </summary>
        public Response25()
        {
        }
    }
}