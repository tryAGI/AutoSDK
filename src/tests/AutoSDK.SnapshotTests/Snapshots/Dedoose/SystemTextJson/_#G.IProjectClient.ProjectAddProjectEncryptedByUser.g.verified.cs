//HintName: G.IProjectClient.ProjectAddProjectEncryptedByUser.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// AddProjectEncryptedByUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="decription"></param>
        /// <param name="symKeyHash"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Project> ProjectAddProjectEncryptedByUserAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? title = default,
            string? decription = default,
            string? symKeyHash = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}