//HintName: G.IMigrationsClient.MigrationsMapCommitAuthor.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            global::G.MigrationsMapCommitAuthorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="email">
        /// The new Git author email.
        /// </param>
        /// <param name="name">
        /// The new Git author name.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            string? email = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}