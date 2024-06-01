//HintName: G.DependabotClient.DependabotListAlertsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for an enterprise
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="scope"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<DependabotAlertWithRepository>> DependabotListAlertsForEnterpriseAsync(
            string enterprise,
            string state,
            string severity,
            string ecosystem,
            string package,
            DependabotListAlertsForEnterpriseScope scope,
            DependabotListAlertsForEnterpriseSort sort,
            DependabotListAlertsForEnterpriseDirection direction,
            string before,
            string after,
            int first,
            int last,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var scopeValue = scope switch
            {
                DependabotListAlertsForEnterpriseScope.Development => "development",
                DependabotListAlertsForEnterpriseScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                DependabotListAlertsForEnterpriseSort.Created => "created",
                DependabotListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                DependabotListAlertsForEnterpriseDirection.Asc => "asc",
                DependabotListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/enterprises/{enterprise}/dependabot/alerts?state={state}&severity={severity}&ecosystem={ecosystem}&package={package}&scope={scopeValue}&sort={sortValue}&direction={directionValue}&before={before}&after={after}&first={first}&last={last}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<DependabotAlertWithRepository>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}