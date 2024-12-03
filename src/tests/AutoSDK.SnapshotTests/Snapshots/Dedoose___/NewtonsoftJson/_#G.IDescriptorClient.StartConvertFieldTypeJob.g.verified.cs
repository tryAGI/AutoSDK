//HintName: G.IDescriptorClient.StartConvertFieldTypeJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartConvertFieldTypeJob<br/>
        /// StartConvertFieldTypeJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartConvertFieldTypeJobAsync(
            global::G.StartConvertFieldTypeJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartConvertFieldTypeJob<br/>
        /// StartConvertFieldTypeJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldId"></param>
        /// <param name="newFieldType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartConvertFieldTypeJobAsync(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Guid fieldId,
            int newFieldType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}