//HintName: G.Models.AzureBlobStorageDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos and assets to [Azure Blob Storage](https://learn.microsoft.com/en-us/azure/storage/blobs/). Send files to any container with a custom prefix and filename. Azure credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/azure-blob-storage), not in the request.
    /// </summary>
    public sealed partial class AzureBlobStorageDestination
    {
        /// <summary>
        /// The destination to send assets to - set to `azure-blob-storage` for Azure Blob Storage.<br/>
        /// Default Value: azure-blob-storage<br/>
        /// Example: azure-blob-storage
        /// </summary>
        /// <default>"azure-blob-storage"</default>
        /// <example>azure-blob-storage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; } = "azure-blob-storage";

        /// <summary>
        /// Pass additional options to control how files are stored in Azure Blob Storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.AzureBlobStorageDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobStorageDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `azure-blob-storage` for Azure Blob Storage.<br/>
        /// Default Value: azure-blob-storage<br/>
        /// Example: azure-blob-storage
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how files are stored in Azure Blob Storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureBlobStorageDestination(
            string provider,
            global::G.AzureBlobStorageDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobStorageDestination" /> class.
        /// </summary>
        public AzureBlobStorageDestination()
        {
        }
    }
}