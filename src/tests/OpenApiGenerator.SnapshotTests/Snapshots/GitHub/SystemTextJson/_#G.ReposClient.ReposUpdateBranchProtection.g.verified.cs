//HintName: G.ReposClient.ReposUpdateBranchProtection.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update branch protection
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProtectedBranch> ReposUpdateBranchProtectionAsync(
            string owner,
            string repo,
            string branch,
            ReposUpdateBranchProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/branches/{branch}/protection", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ProtectedBranch?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update branch protection
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="requiredStatusChecks"></param>
        /// <param name="enforceAdmins"></param>
        /// <param name="requiredPullRequestReviews"></param>
        /// <param name="restrictions"></param>
        /// <param name="requiredLinearHistory"></param>
        /// <param name="allowForcePushes"></param>
        /// <param name="allowDeletions"></param>
        /// <param name="blockCreations"></param>
        /// <param name="requiredConversationResolution"></param>
        /// <param name="lockBranch"></param>
        /// <param name="allowForkSyncing"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProtectedBranch> ReposUpdateBranchProtectionAsync(
            string owner,
            string repo,
            string branch,
            ReposUpdateBranchProtectionRequestRequiredStatusChecks? requiredStatusChecks,
            bool? enforceAdmins,
            ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? requiredPullRequestReviews,
            ReposUpdateBranchProtectionRequestRestrictions? restrictions,
            bool requiredLinearHistory = default,
            bool? allowForcePushes = default,
            bool allowDeletions = default,
            bool blockCreations = default,
            bool requiredConversationResolution = default,
            bool lockBranch = false,
            bool allowForkSyncing = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateBranchProtectionRequest
            {
                RequiredStatusChecks = requiredStatusChecks,
                EnforceAdmins = enforceAdmins,
                RequiredPullRequestReviews = requiredPullRequestReviews,
                Restrictions = restrictions,
                RequiredLinearHistory = requiredLinearHistory,
                AllowForcePushes = allowForcePushes,
                AllowDeletions = allowDeletions,
                BlockCreations = blockCreations,
                RequiredConversationResolution = requiredConversationResolution,
                LockBranch = lockBranch,
                AllowForkSyncing = allowForkSyncing,
            };

            return await ReposUpdateBranchProtectionAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}