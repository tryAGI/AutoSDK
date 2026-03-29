//HintName: G.IStorageGcsClient.Validate2.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsClient
    {
        /// <summary>
        /// Validate import storage<br/>
        /// Validate a specific GCS import storage connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Validate2Async(

            global::G.ApiStoragesGcsValidateCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate import storage<br/>
        /// Validate a specific GCS import storage connection.
        /// </summary>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="prefix">
        /// GCS bucket prefix
        /// </param>
        /// <param name="presign">
        /// Presign URLs for direct download<br/>
        /// Default Value: true
        /// </param>
        /// <param name="presignTtl">
        /// Presign TTL in minutes<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="regexFilter">
        /// Cloud storage regex for filtering objects. You must specify it otherwise no objects will be imported.
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        /// <param name="useBlobUrls">
        /// Interpret objects as BLOBs and generate URLs. For example, if your bucket contains images, you can use this option to generate URLs for these images. If set to False, it will read the content of the file and load it into Label Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task Validate2Async(
            string? bucket = default,
            string? description = default,
            string? googleApplicationCredentials = default,
            string? googleProjectId = default,
            int? id = default,
            string? prefix = default,
            bool? presign = default,
            int? presignTtl = default,
            int? project = default,
            string? regexFilter = default,
            string? title = default,
            bool? useBlobUrls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}