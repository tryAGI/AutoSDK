//HintName: G.ReposClient.ReposListActivities.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repository activities
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="@ref"></param>
        /// <param name="actor"></param>
        /// <param name="timePeriod"></param>
        /// <param name="activityType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Activity>> ReposListActivitiesAsync(
            string owner,
            string repo,
            ReposListActivitiesDirection direction,
            int perPage,
            string before,
            string after,
            string @ref,
            string actor,
            ReposListActivitiesTimePeriod timePeriod,
            ReposListActivitiesActivityType activityType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var directionValue = direction switch
            {
                ReposListActivitiesDirection.Asc => "asc",
                ReposListActivitiesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var timePeriodValue = timePeriod switch
            {
                ReposListActivitiesTimePeriod.Day => "day",
                ReposListActivitiesTimePeriod.Week => "week",
                ReposListActivitiesTimePeriod.Month => "month",
                ReposListActivitiesTimePeriod.Quarter => "quarter",
                ReposListActivitiesTimePeriod.Year => "year",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var activityTypeValue = activityType switch
            {
                ReposListActivitiesActivityType.Push => "push",
                ReposListActivitiesActivityType.ForcePush => "force_push",
                ReposListActivitiesActivityType.BranchCreation => "branch_creation",
                ReposListActivitiesActivityType.BranchDeletion => "branch_deletion",
                ReposListActivitiesActivityType.PrMerge => "pr_merge",
                ReposListActivitiesActivityType.MergeQueueMerge => "merge_queue_merge",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/activity?direction={directionValue}&per_page={perPage}&before={before}&after={after}&ref={@ref}&actor={actor}&time_period={timePeriodValue}&activity_type={activityTypeValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Activity>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}