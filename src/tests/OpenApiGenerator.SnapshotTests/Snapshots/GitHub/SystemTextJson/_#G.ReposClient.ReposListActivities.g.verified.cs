//HintName: G.ReposClient.ReposListActivities.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListActivitiesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.ReposListActivitiesDirection? direction,
            ref int perPage,
            ref string? before,
            ref string? after,
            ref string? @ref,
            ref string? actor,
            ref global::G.ReposListActivitiesTimePeriod? timePeriod,
            ref global::G.ReposListActivitiesActivityType? activityType);
        partial void PrepareReposListActivitiesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposListActivitiesDirection? direction,
            int perPage,
            string? before,
            string? after,
            string? @ref,
            string? actor,
            global::G.ReposListActivitiesTimePeriod? timePeriod,
            global::G.ReposListActivitiesActivityType? activityType);
        partial void ProcessReposListActivitiesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListActivitiesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository activities<br/>
        /// Lists a detailed history of changes to a repository, such as pushes, merges, force pushes, and branch changes, and associates these changes with commits and users.<br/>
        /// For more information about viewing repository activity,<br/>
        /// see "[Viewing activity and data for your repository](https://docs.github.com/repositories/viewing-activity-and-data-for-your-repository)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="ref"></param>
        /// <param name="actor"></param>
        /// <param name="timePeriod"></param>
        /// <param name="activityType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Activity>> ReposListActivitiesAsync(
            string owner,
            string repo,
            global::G.ReposListActivitiesDirection? direction = global::G.ReposListActivitiesDirection.Desc,
            int perPage = 30,
            string? before = default,
            string? after = default,
            string? @ref = default,
            string? actor = default,
            global::G.ReposListActivitiesTimePeriod? timePeriod = default,
            global::G.ReposListActivitiesActivityType? activityType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListActivitiesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                direction: ref direction,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                @ref: ref @ref,
                actor: ref actor,
                timePeriod: ref timePeriod,
                activityType: ref activityType);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/activity?direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&per_page={perPage}&before={before}&after={after}&ref={@ref}&actor={actor}&time_period={(global::System.Uri.EscapeDataString(timePeriod?.ToValueString() ?? string.Empty))}&activity_type={(global::System.Uri.EscapeDataString(activityType?.ToValueString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListActivitiesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                direction: direction,
                perPage: perPage,
                before: before,
                after: after,
                @ref: @ref,
                actor: actor,
                timePeriod: timePeriod,
                activityType: activityType);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposListActivitiesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListActivitiesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Activity>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}