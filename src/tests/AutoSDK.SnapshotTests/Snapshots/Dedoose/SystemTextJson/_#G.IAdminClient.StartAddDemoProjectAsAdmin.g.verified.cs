//HintName: G.IAdminClient.StartAddDemoProjectAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// StartAddDemoProject<br/>
        /// StartAddDemoProject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddDemoProjectAsAdminAsync(
            global::G.StartAddDemoProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartAddDemoProject<br/>
        /// StartAddDemoProject
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddDemoProjectAsAdminAsync(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}