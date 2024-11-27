//HintName: G.IExcerptClient.StartDeleteExcerptsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// StartDeleteExcerptsJob<br/>
        /// StartDeleteExcerptsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteExcerptsJobAsync(
            global::G.StartDeleteExcerptsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartDeleteExcerptsJob<br/>
        /// StartDeleteExcerptsJob
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartDeleteExcerptsJobAsync(
            global::System.Guid currentProjectId,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}