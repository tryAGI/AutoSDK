//HintName: G.Models.UploadResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of resource (an upload), it's id and attributes of the upload request.
    /// </summary>
    public sealed partial class UploadResponseData
    {
        /// <summary>
        /// The type of resource, in this case it is an upload.<br/>
        /// Example: upload
        /// </summary>
        /// <example>upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The upload file id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </summary>
        /// <example>zzytey4v-32km-kq1z-aftr-3kcuqi0brad2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The id and attributes of the upload file including the signed URL to send the binary file data to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UploadResponseAttributes Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponseData" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of resource, in this case it is an upload.<br/>
        /// Example: upload
        /// </param>
        /// <param name="id">
        /// The upload file id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </param>
        /// <param name="attributes">
        /// The id and attributes of the upload file including the signed URL to send the binary file data to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadResponseData(
            string type,
            string id,
            global::G.UploadResponseAttributes attributes)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponseData" /> class.
        /// </summary>
        public UploadResponseData()
        {
        }
    }
}