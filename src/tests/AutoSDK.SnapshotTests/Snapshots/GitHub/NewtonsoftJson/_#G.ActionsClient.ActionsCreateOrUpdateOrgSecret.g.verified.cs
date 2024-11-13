//HintName: G.ActionsClient.ActionsCreateOrUpdateOrgSecret.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsCreateOrUpdateOrgSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string secretName,
            global::G.ActionsCreateOrUpdateOrgSecretRequest request);
        partial void PrepareActionsCreateOrUpdateOrgSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string secretName,
            global::G.ActionsCreateOrUpdateOrgSecretRequest request);
        partial void ProcessActionsCreateOrUpdateOrgSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsCreateOrUpdateOrgSecretResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update an organization secret<br/>
        /// Creates or updates an organization secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsCreateOrUpdateOrgSecretAsync(
            string org,
            string secretName,
            global::G.ActionsCreateOrUpdateOrgSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsCreateOrUpdateOrgSecretArguments(
                httpClient: HttpClient,
                org: ref org,
                secretName: ref secretName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/secrets/{secretName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsCreateOrUpdateOrgSecretRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                secretName: secretName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsCreateOrUpdateOrgSecretResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessActionsCreateOrUpdateOrgSecretResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.EmptyObject.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    await global::G.EmptyObject.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create or update an organization secret<br/>
        /// Creates or updates an organization secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`admin:org` scope to use this endpoint. If the repository is private, OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an organization public key](https://docs.github.com/rest/actions/secrets#get-an-organization-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can manage the list of selected repositories using the [List selected repositories for an organization secret](https://docs.github.com/rest/actions/secrets#list-selected-repositories-for-an-organization-secret), [Set selected repositories for an organization secret](https://docs.github.com/rest/actions/secrets#set-selected-repositories-for-an-organization-secret), and [Remove selected repository from an organization secret](https://docs.github.com/rest/actions/secrets#remove-selected-repository-from-an-organization-secret) endpoints.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EmptyObject> ActionsCreateOrUpdateOrgSecretAsync(
            string org,
            string secretName,
            global::G.ActionsCreateOrUpdateOrgSecretRequestVisibility visibility,
            string? encryptedValue = default,
            string? keyId = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsCreateOrUpdateOrgSecretRequest
            {
                EncryptedValue = encryptedValue,
                KeyId = keyId,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            return await ActionsCreateOrUpdateOrgSecretAsync(
                org: org,
                secretName: secretName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}