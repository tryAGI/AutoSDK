//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            ref string packageName,
            ref string org,
            ref int? page,
            ref int? perPage,
            ref global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state);
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int? page,
            int? perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state);
        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List package versions for a package owned by an organization<br/>
        /// Lists package versions for a package owned by an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint if the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state">
        /// Default Value: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByOrgAsync(
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int? page = 1,
            int? perPage = 30,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state = global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                org: ref org,
                page: ref page,
                perPage: ref perPage,
                state: ref state);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/packages/{packageType}/{packageName}/versions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                packageName: packageName,
                org: org,
                page: page,
                perPage: perPage,
                state: state);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByOrgResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.PackageVersion>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}