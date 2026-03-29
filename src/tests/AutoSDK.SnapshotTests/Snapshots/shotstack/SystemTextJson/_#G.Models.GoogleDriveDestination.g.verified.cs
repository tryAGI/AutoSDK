//HintName: G.Models.GoogleDriveDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send rendered videos and assets to the [Google Drive](https://shotstack.io/docs/guide/serving-assets/destinations/google-drive/) cloud storage service. Google Drive uses OAuth and you must authenticate and link your Google account via  [dashboard](https://dashboard.shotstack.io/integrations/google-drive), not in the request.
    /// </summary>
    public sealed partial class GoogleDriveDestination
    {
        /// <summary>
        /// The destination to send assets to - set to `google-drive` for Google Drive.<br/>
        /// Default Value: google-drive<br/>
        /// Example: google-drive
        /// </summary>
        /// <default>"google-drive"</default>
        /// <example>google-drive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; } = "google-drive";

        /// <summary>
        /// Pass the folder ID and options to configure how assets are stored in Google Drive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GoogleDriveDestinationOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `google-drive` for Google Drive.<br/>
        /// Default Value: google-drive<br/>
        /// Example: google-drive
        /// </param>
        /// <param name="options">
        /// Pass the folder ID and options to configure how assets are stored in Google Drive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveDestination(
            string provider,
            global::G.GoogleDriveDestinationOptions options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveDestination" /> class.
        /// </summary>
        public GoogleDriveDestination()
        {
        }
    }
}