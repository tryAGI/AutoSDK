//HintName: G.PackagesClient.PackagesRestorePackageForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesRestorePackageForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesRestorePackageForAuthenticatedUserPackageType packageType,
            ref string packageName,
            ref string? token);
        partial void PreparePackagesRestorePackageForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesRestorePackageForAuthenticatedUserPackageType packageType,
            string packageName,
            string? token);
        partial void ProcessPackagesRestorePackageForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesRestorePackageForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Restore a package for the authenticated user<br/>
        /// Restores a package owned by the authenticated user.<br/>
        /// You can restore a deleted package under the following conditions:<br/>
        ///   - The package was deleted within the last 30 days.<br/>
        ///   - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `write:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> PackagesRestorePackageForAuthenticatedUserAsync(
            global::G.PackagesRestorePackageForAuthenticatedUserPackageType packageType,
            string packageName,
            string? token,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePackagesRestorePackageForAuthenticatedUserArguments(
                httpClient: _httpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                token: ref token);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/packages/{packageType}/{packageName}/restore?token={token}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePackagesRestorePackageForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                packageType: packageType,
                packageName: packageName,
                token: token);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPackagesRestorePackageForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPackagesRestorePackageForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}