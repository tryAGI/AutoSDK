//HintName: G.IStorageS3Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageS3Client
    {
        /// <summary>
        /// Create export storage<br/>
        /// Create a new S3 export storage connection to store annotations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.S3ExportStorage> CreateAsync(

            global::G.ApiStoragesExportS3CreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create export storage<br/>
        /// Create a new S3 export storage connection to store annotations.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// AWS_ACCESS_KEY_ID
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// AWS_SECRET_ACCESS_KEY
        /// </param>
        /// <param name="awsSessionToken">
        /// AWS_SESSION_TOKEN
        /// </param>
        /// <param name="awsSseKmsKeyId">
        /// AWS SSE KMS Key ID
        /// </param>
        /// <param name="bucket">
        /// S3 bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="prefix">
        /// S3 bucket prefix
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regionName">
        /// AWS Region
        /// </param>
        /// <param name="s3Endpoint">
        /// S3 Endpoint
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.S3ExportStorage> CreateAsync(
            string? awsAccessKeyId = default,
            string? awsSecretAccessKey = default,
            string? awsSessionToken = default,
            string? awsSseKmsKeyId = default,
            string? bucket = default,
            bool? canDeleteObjects = default,
            string? description = default,
            string? prefix = default,
            int? project = default,
            string? regionName = default,
            string? s3Endpoint = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}