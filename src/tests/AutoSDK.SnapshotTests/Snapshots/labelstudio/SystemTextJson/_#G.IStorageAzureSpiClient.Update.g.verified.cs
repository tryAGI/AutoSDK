//HintName: G.IStorageAzureSpiClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageAzureSpiClient
    {
        /// <summary>
        /// ✨ Update Azure SPI import storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific Azure import storage connection that was set up with Service Principal authentication.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AzureServicePrincipalImportStorage> UpdateAsync(
            int id,

            global::G.PatchedAzureServicePrincipalImportStorageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update Azure SPI import storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update a specific Azure import storage connection that was set up with Service Principal authentication.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="clientId">
        /// Azure Blob Service Principal Client ID
        /// </param>
        /// <param name="clientSecret">
        /// Azure Blob Service Principal Client Secret
        /// </param>
        /// <param name="container">
        /// Azure blob container
        /// </param>
        /// <param name="description">
        /// Cloud storage description
        /// </param>
        /// <param name="lastSync">
        /// Last sync finished time
        /// </param>
        /// <param name="lastSyncCount">
        /// Count of tasks synced last time
        /// </param>
        /// <param name="lastSyncJob">
        /// Last sync job ID
        /// </param>
        /// <param name="meta">
        /// Meta and debug information about storage processes
        /// </param>
        /// <param name="prefix">
        /// Azure blob prefix name
        /// </param>
        /// <param name="presign">
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presigned URLs TTL (in minutes)
        /// </param>
        /// <param name="project">
        /// A unique integer value identifying this project.
        /// </param>
        /// <param name="recursiveScan">
        /// Perform recursive scan
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects
        /// </param>
        /// <param name="status">
        /// * `initialized` - Initialized<br/>
        /// * `queued` - Queued<br/>
        /// * `in_progress` - In progress<br/>
        /// * `failed` - Failed<br/>
        /// * `completed` - Completed<br/>
        /// * `completed_with_errors` - Completed with errors
        /// </param>
        /// <param name="synchronizable">
        /// Default Value: true
        /// </param>
        /// <param name="tenantId">
        /// Azure Tenant ID
        /// </param>
        /// <param name="title">
        /// Cloud storage title
        /// </param>
        /// <param name="traceback">
        /// Traceback report for the last failed sync
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs
        /// </param>
        /// <param name="userDelegationKey">
        /// User Delegation Key (Backend)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AzureServicePrincipalImportStorage> UpdateAsync(
            int id,
            string? accountName = default,
            string? clientId = default,
            string? clientSecret = default,
            string? container = default,
            string? description = default,
            global::System.DateTime? lastSync = default,
            int? lastSyncCount = default,
            string? lastSyncJob = default,
            object? meta = default,
            string? prefix = default,
            bool? presign = default,
            int? presignTtl = default,
            int? project = default,
            bool? recursiveScan = default,
            string? regexFilter = default,
            global::G.StatusC5aEnum? status = default,
            bool? synchronizable = default,
            string? tenantId = default,
            string? title = default,
            string? traceback = default,
            bool? useBlobUrls = default,
            string? userDelegationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}