//HintName: G.IAccountClient.StartGetAccountProjectInfoJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// StartGetAccountProjectInfoJob<br/>
        /// StartGetAccountProjectInfoJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetAccountProjectInfoJobAsync(
            global::G.StartGetAccountProjectInfoJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartGetAccountProjectInfoJob<br/>
        /// StartGetAccountProjectInfoJob
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetAccountProjectInfoJobAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}