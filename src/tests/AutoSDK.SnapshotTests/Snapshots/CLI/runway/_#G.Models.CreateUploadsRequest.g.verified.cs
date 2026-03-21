//HintName: G.Models.CreateUploadsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUploadsRequest
    {
        /// <summary>
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The type of upload to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateUploadsRequestTypeJsonConverter))]
        public global::G.CreateUploadsRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadsRequest" /> class.
        /// </summary>
        /// <param name="filename">
        /// The filename of the file to upload. Must have a valid extension and be a supported media type (image, video, or audio).
        /// </param>
        /// <param name="type">
        /// The type of upload to create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUploadsRequest(
            string filename,
            global::G.CreateUploadsRequestType type)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUploadsRequest" /> class.
        /// </summary>
        public CreateUploadsRequest()
        {
        }
    }
}