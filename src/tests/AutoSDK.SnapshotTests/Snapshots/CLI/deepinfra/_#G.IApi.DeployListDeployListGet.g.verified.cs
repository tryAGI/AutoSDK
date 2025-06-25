//HintName: G.IApi.DeployListDeployListGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy List
        /// </summary>
        /// <param name="status">
        /// A list of statuses that should be returned, separated by comma. Allowed values in the list are: initializing,deploying,running,failed,deleted
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DeploymentOut>> DeployListDeployListGetAsync(
            string? status = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}