//HintName: G.Models.CloudGoogleDriveDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudGoogleDriveDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The ID of the Google Drive folder to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderId { get; set; }

        /// <summary>
        /// The service account key JSON to use for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_key")]
        public global::System.Collections.Generic.Dictionary<string, string>? ServiceAccountKey { get; set; }

        /// <summary>
        /// Default Value: CloudGoogleDriveDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudGoogleDriveDataSource" /> class.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the Google Drive folder to read from.
        /// </param>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="serviceAccountKey">
        /// The service account key JSON to use for authentication.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudGoogleDriveDataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudGoogleDriveDataSource(
            string folderId,
            bool? supportsAccessControl,
            global::System.Collections.Generic.Dictionary<string, string>? serviceAccountKey,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.FolderId = folderId ?? throw new global::System.ArgumentNullException(nameof(folderId));
            this.ServiceAccountKey = serviceAccountKey;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudGoogleDriveDataSource" /> class.
        /// </summary>
        public CloudGoogleDriveDataSource()
        {
        }
    }
}