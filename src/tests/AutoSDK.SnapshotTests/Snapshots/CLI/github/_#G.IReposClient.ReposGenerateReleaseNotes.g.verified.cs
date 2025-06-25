//HintName: G.IReposClient.ReposGenerateReleaseNotes.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Generate release notes content for a release<br/>
        /// Generate a name and body describing a [release](https://docs.github.com/rest/releases/releases#get-a-release). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReleaseNotesContent> ReposGenerateReleaseNotesAsync(
            string owner,
            string repo,
            global::G.ReposGenerateReleaseNotesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate release notes content for a release<br/>
        /// Generate a name and body describing a [release](https://docs.github.com/rest/releases/releases#get-a-release). The body content will be markdown formatted and contain information like the changes since last release and users who contributed. The generated release notes are not saved anywhere. They are intended to be generated and used when creating a new release.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tagName">
        /// The tag name for the release. This can be an existing tag or a new one.
        /// </param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that will be the target for the release's tag. Required if the supplied tag_name does not reference an existing tag. Ignored if the tag_name already exists.
        /// </param>
        /// <param name="previousTagName">
        /// The name of the previous tag to use as the starting point for the release notes. Use to manually specify the range for the set of changes considered as part this release.
        /// </param>
        /// <param name="configurationFilePath">
        /// Specifies a path to a file in the repository containing configuration settings used for generating the release notes. If unspecified, the configuration file located in the repository at '.github/release.yml' or '.github/release.yaml' will be used. If that is not present, the default configuration will be used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReleaseNotesContent> ReposGenerateReleaseNotesAsync(
            string owner,
            string repo,
            string tagName,
            string? targetCommitish = default,
            string? previousTagName = default,
            string? configurationFilePath = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}