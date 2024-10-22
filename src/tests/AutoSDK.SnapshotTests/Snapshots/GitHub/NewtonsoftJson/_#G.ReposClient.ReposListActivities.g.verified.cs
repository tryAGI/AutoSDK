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
            ref int? perPage,
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
            int? perPage,
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
            int? perPage = 30,
            string? before = default,
            string? after = default,
            string? @ref = default,
            string? actor = default,
            global::G.ReposListActivitiesTimePeriod? timePeriod = default,
            global::G.ReposListActivitiesActivityType? activityType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposListActivitiesArguments(
                httpClient: HttpClient,
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

            var directionValue = direction switch
            {
                global::G.ReposListActivitiesDirection.Asc => "asc",
                global::G.ReposListActivitiesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var timePeriodValue = timePeriod switch
            {
                global::G.ReposListActivitiesTimePeriod.Day => "day",
                global::G.ReposListActivitiesTimePeriod.Week => "week",
                global::G.ReposListActivitiesTimePeriod.Month => "month",
                global::G.ReposListActivitiesTimePeriod.Quarter => "quarter",
                global::G.ReposListActivitiesTimePeriod.Year => "year",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var activityTypeValue = activityType switch
            {
                global::G.ReposListActivitiesActivityType.Push => "push",
                global::G.ReposListActivitiesActivityType.ForcePush => "force_push",
                global::G.ReposListActivitiesActivityType.BranchCreation => "branch_creation",
                global::G.ReposListActivitiesActivityType.BranchDeletion => "branch_deletion",
                global::G.ReposListActivitiesActivityType.PrMerge => "pr_merge",
                global::G.ReposListActivitiesActivityType.MergeQueueMerge => "merge_queue_merge",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/activity",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("actor", actor) 
                .AddOptionalParameter("time_period", timePeriodValue?.ToString()) 
                .AddOptionalParameter("activity_type", activityTypeValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposListActivitiesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposListActivitiesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposListActivitiesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Activity>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}