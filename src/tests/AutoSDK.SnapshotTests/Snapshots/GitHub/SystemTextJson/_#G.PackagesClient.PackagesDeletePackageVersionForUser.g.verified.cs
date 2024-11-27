//HintName: G.PackagesClient.PackagesDeletePackageVersionForUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesDeletePackageVersionForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            ref string packageName,
            ref string username,
            ref int packageVersionId);
        partial void PreparePackagesDeletePackageVersionForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId);
        partial void ProcessPackagesDeletePackageVersionForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete package version for a user<br/>
        /// Deletes a specific package version for a user. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.<br/>
        /// If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must have admin permissions to the package. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PackagesDeletePackageVersionForUserAsync(
            global::G.PackagesDeletePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesDeletePackageVersionForUserArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                username: ref username,
                packageVersionId: ref packageVersionId);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/packages/{packageType}/{packageName}/versions/{packageVersionId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesDeletePackageVersionForUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                packageName: packageName,
                username: username,
                packageVersionId: packageVersionId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesDeletePackageVersionForUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
        }
    }
}