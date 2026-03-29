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
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Pass additional options to control how files are stored in Azure Blob Storage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.AzureBlobStorageDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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