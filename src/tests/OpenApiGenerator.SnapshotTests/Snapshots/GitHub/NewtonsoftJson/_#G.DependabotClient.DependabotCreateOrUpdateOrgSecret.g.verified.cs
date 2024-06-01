//HintName: G.DependabotClient.DependabotCreateOrUpdateOrgSecret.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        /// <summary>
        /// Create or update an organization secret
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> DependabotCreateOrUpdateOrgSecretAsync(
            string org,
            string secretName,
            DependabotCreateOrUpdateOrgSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/dependabot/secrets/{secretName}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<EmptyObject?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update an organization secret
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="encryptedValue"></param>
        /// <param name="keyId"></param>
        /// <param name="visibility"></param>
        /// <param name="selectedRepositoryIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> DependabotCreateOrUpdateOrgSecretAsync(
            string org,
            string secretName,
            DependabotCreateOrUpdateOrgSecretRequestVisibility visibility,
            string? encryptedValue = default,
            string? keyId = default,
            global::System.Collections.Generic.IList<string?>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new DependabotCreateOrUpdateOrgSecretRequest
            {
                EncryptedValue = encryptedValue,
                KeyId = keyId,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            return await DependabotCreateOrUpdateOrgSecretAsync(
                org: org,
                secretName: secretName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}