//HintName: G.SecretScanningClient.SecretScanningListAlertsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for an enterprise
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="perPage"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SecretScanningListAlertsForEnterpriseAsync(
            string enterprise,
            SecretScanningListAlertsForEnterpriseState state,
            string secretType,
            string resolution,
            SecretScanningListAlertsForEnterpriseSort sort,
            SecretScanningListAlertsForEnterpriseDirection direction,
            int perPage,
            string before,
            string after,
            string validity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var stateValue = state switch
            {
                SecretScanningListAlertsForEnterpriseState.Open => "open",
                SecretScanningListAlertsForEnterpriseState.Resolved => "resolved",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                SecretScanningListAlertsForEnterpriseSort.Created => "created",
                SecretScanningListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                SecretScanningListAlertsForEnterpriseDirection.Asc => "asc",
                SecretScanningListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/enterprises/{enterprise}/secret-scanning/alerts?state={stateValue}&secret_type={secretType}&resolution={resolution}&sort={sortValue}&direction={directionValue}&per_page={perPage}&before={before}&after={after}&validity={validity}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}