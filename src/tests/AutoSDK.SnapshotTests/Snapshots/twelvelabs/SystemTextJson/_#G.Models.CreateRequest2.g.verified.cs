//HintName: G.Models.CreateRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest2
    {
        /// <summary>
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod Method { get; set; }

        /// <summary>
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Direct uploads are limited to 200MB. For files larger than 200MB, use the [Multipart Upload API](/api-reference/upload-content/multipart-uploads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// URL uploads have a maximum limit of 4GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        /// <param name="method">
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </param>
        /// <param name="file">
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Direct uploads are limited to 200MB. For files larger than 200MB, use the [Multipart Upload API](/api-reference/upload-content/multipart-uploads).
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// URL uploads have a maximum limit of 4GB.
        /// </param>
        /// <param name="filename">
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest2(
            global::G.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod method,
            byte[]? file,
            string? url,
            string? filename)
        {
            this.Method = method;
            this.File = file;
            this.Url = url;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest2" /> class.
        /// </summary>
        public CreateRequest2()
        {
        }
    }
}