//HintName: G.IReposClient.ReposCompareCommits.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Compare two commits<br/>
        /// Compares two commits against one another. You can compare refs (branches or tags) and commit SHAs in the same repository, or you can compare refs and commit SHAs that exist in different repositories within the same repository network, including fork branches. For more information about how to view a repository's network, see "[Understanding connections between repositories](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository/understanding-connections-between-repositories)."<br/>
        /// This endpoint is equivalent to running the `git log BASE..HEAD` command, but it returns commits in a different order. The `git log BASE..HEAD` command returns commits in reverse chronological order, whereas the API returns commits in chronological order.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.diff`**: Returns the diff of the commit.<br/>
        /// - **`application/vnd.github.patch`**: Returns the patch of the commit. Diffs with binary data will have no `patch` property.<br/>
        /// The API response includes details about the files that were changed between the two commits. This includes the status of the change (if a file was added, removed, modified, or renamed), and details of the change itself. For example, files with a `renamed` status have a `previous_filename` field showing the previous filename of the file, and files with a `modified` status have a `patch` field showing the changes made to the file.<br/>
        /// When calling this endpoint without any paging parameter (`per_page` or `page`), the returned list is limited to 250 commits, and the last commit in the list is the most recent of the entire comparison.<br/>
        /// **Working with large comparisons**<br/>
        /// To process a response with a large number of commits, use a query parameter (`per_page` or `page`) to paginate the results. When using pagination:<br/>
        /// - The list of changed files is only shown on the first page of results, and it includes up to 300 changed files for the entire comparison.<br/>
        /// - The results are returned in chronological order, but the last commit in the returned list may not be the most recent one in the entire set if there are more pages of results.<br/>
        /// For more information on working with pagination, see "[Using pagination in the REST API](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api)."<br/>
        /// **Signature verification object**<br/>
        /// The response will include a `verification` object that describes the result of verifying the commit's signature. The `verification` object includes the following fields:<br/>
        /// | Name | Type | Description |<br/>
        /// | ---- | ---- | ----------- |<br/>
        /// | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |<br/>
        /// | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. |<br/>
        /// | `signature` | `string` | The signature that was extracted from the commit. |<br/>
        /// | `payload` | `string` | The value that was signed. |<br/>
        /// These are the possible values for `reason` in the `verification` object:<br/>
        /// | Value | Description |<br/>
        /// | ----- | ----------- |<br/>
        /// | `expired_key` | The key that made the signature is expired. |<br/>
        /// | `not_signing_key` | The "signing" flag is not among the usage flags in the GPG key that made the signature. |<br/>
        /// | `gpgverify_error` | There was an error communicating with the signature verification service. |<br/>
        /// | `gpgverify_unavailable` | The signature verification service is currently unavailable. |<br/>
        /// | `unsigned` | The object does not include a signature. |<br/>
        /// | `unknown_signature_type` | A non-PGP signature was found in the commit. |<br/>
        /// | `no_user` | No user was associated with the `committer` email address in the commit. |<br/>
        /// | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. |<br/>
        /// | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. |<br/>
        /// | `unknown_key` | The key that made the signature has not been registered with any user's account. |<br/>
        /// | `malformed_signature` | There was an error parsing the signature. |<br/>
        /// | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. |<br/>
        /// | `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="basehead"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CommitComparison> ReposCompareCommitsAsync(
            string owner,
            string repo,
            string basehead,
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}