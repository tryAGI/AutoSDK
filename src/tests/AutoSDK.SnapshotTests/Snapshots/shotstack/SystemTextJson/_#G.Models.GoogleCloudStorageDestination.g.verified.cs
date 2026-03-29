//HintName: G.Models.GoogleCloudStorageDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos and assets to a [Google Cloud Storage](https://cloud.google.com/storage) bucket. Send files with your own prefix and filename. Google Cloud credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/google-cloud-storage), not in the request.
    /// </summary>
    public sealed partial class GoogleCloudStorageDestination
    {
        /// <summary>
        /// The destination to send assets to - set to `google-cloud-storage` for Google Cloud Storage.<br/>
        /// Default Value: google-cloud-storage<br/>
        /// Example: google-cloud-storage
        /// </summary>
        /// <default>"google-cloud-storage"</default>
        /// <example>google-cloud-storage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; } = "google-cloud-storage";

        /// <summary>
        /// Pass additional options to control how files are stored in Google Cloud Storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.GoogleCloudStorageDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudStorageDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `google-cloud-storage` for Google Cloud Storage.<br/>
        /// Default Value: google-cloud-storage<br/>
        /// Example: google-cloud-storage
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how files are stored in Google Cloud Storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleCloudStorageDestination(
            string provider,
            global::G.GoogleCloudStorageDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleCloudStorageDestination" /> class.
        /// </summary>
        public GoogleCloudStorageDestination()
        {
        }
    }
}