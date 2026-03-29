//HintName: G.IEnvironmentsClient.EnvironmentsDeleteEnvironment.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Delete Environment<br/>
        /// Removes environment from list of environments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsDeleteEnvironmentResponse> EnvironmentsDeleteEnvironmentAsync(
            string id,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment<br/>
        /// Removes environment from list of environments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsDeleteEnvironmentResponse> EnvironmentsDeleteEnvironmentAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}