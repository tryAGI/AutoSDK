//HintName: G.Models.GeneratedFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A file generated on behalf of a user.
    /// </summary>
    public sealed partial class GeneratedFile
    {
        /// <summary>
        /// Identifier. The name of the generated file. Example: `generatedFiles/abc-123`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// MIME type of the generatedFile.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Output only. The state of the GeneratedFile.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.GeneratedFileState? State { get; set; }

        /// <summary>
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.Status? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedFile" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier. The name of the generated file. Example: `generatedFiles/abc-123`
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the generatedFile.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the GeneratedFile.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
        /// </param>
        public GeneratedFile(
            string? name,
            string? mimeType,
            global::G.GeneratedFileState? state,
            global::G.Status? error)
        {
            this.Name = name;
            this.MimeType = mimeType;
            this.State = state;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedFile" /> class.
        /// </summary>
        public GeneratedFile()
        {
        }
    }
}