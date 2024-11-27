//HintName: G.IProjectClient.AddProjectEncryptedByUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// AddProjectEncryptedByUser<br/>
        /// AddProjectEncryptedByUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> AddProjectEncryptedByUserAsync(
            global::G.AddProjectEncryptedByUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddProjectEncryptedByUser<br/>
        /// AddProjectEncryptedByUser
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="symKeyHash"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> AddProjectEncryptedByUserAsync(
            global::System.Guid userId,
            string title,
            string decription,
            string symKeyHash,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}