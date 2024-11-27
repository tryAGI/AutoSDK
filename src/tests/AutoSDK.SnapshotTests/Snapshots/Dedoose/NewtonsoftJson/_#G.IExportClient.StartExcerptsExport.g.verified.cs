//HintName: G.IExportClient.StartExcerptsExport.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExcerptsExport<br/>
        /// StartExcerptsExport
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExcerptsExportAsync(
            global::G.StartExcerptsExportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExcerptsExport<br/>
        /// StartExcerptsExport
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="options"></param>
        /// <param name="symKeyEncrypted"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExcerptsExportAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds,
            global::G.ExcerptExportOptions options,
            string symKeyEncrypted,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}