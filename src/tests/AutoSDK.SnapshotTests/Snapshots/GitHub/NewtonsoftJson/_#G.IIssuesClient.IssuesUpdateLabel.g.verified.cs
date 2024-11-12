//HintName: G.IIssuesClient.IssuesUpdateLabel.g.cs
#nullable enable

namespace G
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Update a label<br/>
        /// Updates a label using the given label name.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> IssuesUpdateLabelAsync(
            string owner,
            string repo,
            string name,
            global::G.IssuesUpdateLabelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a label<br/>
        /// Updates a label using the given label name.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="newName">
        /// The new name of the label. Emoji can be added to label names, using either native emoji or colon-style markup. For example, typing `:strawberry:` will render the emoji ![:strawberry:](https://github.githubassets.com/images/icons/emoji/unicode/1f353.png ":strawberry:"). For a full list of available emoji and codes, see "[Emoji cheat sheet](https://github.com/ikatyang/emoji-cheat-sheet)."
        /// </param>
        /// <param name="color">
        /// The [hexadecimal color code](http://www.color-hex.com/) for the label, without the leading `#`.
        /// </param>
        /// <param name="description">
        /// A short description of the label. Must be 100 characters or fewer.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> IssuesUpdateLabelAsync(
            string owner,
            string repo,
            string name,
            string? newName = default,
            string? color = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}