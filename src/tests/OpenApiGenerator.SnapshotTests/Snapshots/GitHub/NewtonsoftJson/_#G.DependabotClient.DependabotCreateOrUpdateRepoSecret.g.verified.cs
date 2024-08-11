//HintName: G.DependabotClient.DependabotCreateOrUpdateRepoSecret.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotCreateOrUpdateRepoSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string secretName,
            global::G.DependabotCreateOrUpdateRepoSecretRequest request);
        partial void PrepareDependabotCreateOrUpdateRepoSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string secretName,
            global::G.DependabotCreateOrUpdateRepoSecretRequest request);
        partial void ProcessDependabotCreateOrUpdateRepoSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotCreateOrUpdateRepoSecretResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update a repository secret<br/>
        /// Creates or updates a repository secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> DependabotCreateOrUpdateRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            global::G.DependabotCreateOrUpdateRepoSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDependabotCreateOrUpdateRepoSecretArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                secretName: ref secretName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/dependabot/secrets/{secretName}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotCreateOrUpdateRepoSecretRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                secretName: secretName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotCreateOrUpdateRepoSecretResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotCreateOrUpdateRepoSecretResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.EmptyObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update a repository secret<br/>
        /// Creates or updates a repository secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/dependabot/secrets#get-a-repository-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> DependabotCreateOrUpdateRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            string? encryptedValue = default,
            string? keyId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.DependabotCreateOrUpdateRepoSecretRequest
            {
                EncryptedValue = encryptedValue,
                KeyId = keyId,
            };

            return await DependabotCreateOrUpdateRepoSecretAsync(
                owner: owner,
                repo: repo,
                secretName: secretName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}