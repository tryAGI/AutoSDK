//HintName: G.IProjectClient.AddProjectByUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// AddProjectByUser<br/>
        /// AddProjectByUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> AddProjectByUserAsync(
            global::G.AddProjectByUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddProjectByUser<br/>
        /// AddProjectByUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> AddProjectByUserAsync(
            global::System.Guid userId,
            string title,
            string decription,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}