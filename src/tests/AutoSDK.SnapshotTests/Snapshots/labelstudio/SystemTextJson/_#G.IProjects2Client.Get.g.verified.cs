//HintName: G.IProjects2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Get project by ID<br/>
        /// Retrieve information about a project by project ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="membersLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseProjectResponse> GetAsync(
            int id,
            int? membersLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}