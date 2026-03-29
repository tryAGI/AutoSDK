//HintName: G.Models.AzureBlobStorageBucketPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureBlobStorageBucketPlan
    {
        /// <summary>
        /// This is the blob storage connection string for the Azure resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionString { get; set; }

        /// <summary>
        /// This is the container name for the Azure blob storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerName { get; set; }

        /// <summary>
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobStorageBucketPlan" /> class.
        /// </summary>
        /// <param name="connectionString">
        /// This is the blob storage connection string for the Azure resource.
        /// </param>
        /// <param name="containerName">
        /// This is the container name for the Azure blob storage.
        /// </param>
        /// <param name="path">
        /// This is the path where call artifacts will be stored.<br/>
        /// Usage:<br/>
        /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".<br/>
        /// - To store call artifacts in the root of the bucket, leave this blank.<br/>
        /// @default "/"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureBlobStorageBucketPlan(
            string connectionString,
            string containerName,
            string? path)
        {
            this.ConnectionString = connectionString ?? throw new global::System.ArgumentNullException(nameof(connectionString));
            this.ContainerName = containerName ?? throw new global::System.ArgumentNullException(nameof(containerName));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureBlobStorageBucketPlan" /> class.
        /// </summary>
        public AzureBlobStorageBucketPlan()
        {
        }
    }
}