//HintName: G.Models.PresignedUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a presigned URL.
    /// </summary>
    public sealed partial class PresignedUrl
    {
        /// <summary>
        /// A presigned URL for IO operations against a private file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The time at which the presigned URL expires
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Form fields for a presigned POST request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("form_fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? FormFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// A presigned URL for IO operations against a private file
        /// </param>
        /// <param name="expiresAt">
        /// The time at which the presigned URL expires
        /// </param>
        /// <param name="formFields">
        /// Form fields for a presigned POST request
        /// </param>
        public PresignedUrl(
            string url,
            global::System.DateTime expiresAt,
            global::System.Collections.Generic.Dictionary<string, string>? formFields)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
            this.FormFields = formFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUrl" /> class.
        /// </summary>
        public PresignedUrl()
        {
        }
    }
}