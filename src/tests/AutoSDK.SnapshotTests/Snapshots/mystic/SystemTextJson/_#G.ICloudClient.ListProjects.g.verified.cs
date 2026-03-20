//HintName: G.ICloudClient.ListProjects.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// List Projects<br/>
        /// Get all projects on a user's cloud account
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProjectGet>> ListProjectsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}