//HintName: G.PackagesClient.PackagesListPackagesForOrganization.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        partial void PreparePackagesListPackagesForOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.PackagesListPackagesForOrganizationPackageType packageType,
            ref string org,
            ref global::G.PackagesListPackagesForOrganizationVisibility? visibility,
            ref int? page,
            ref int? perPage);
        partial void PreparePackagesListPackagesForOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PackagesListPackagesForOrganizationPackageType packageType,
            string org,
            global::G.PackagesListPackagesForOrganizationVisibility? visibility,
            int? page,
            int? perPage);
        partial void ProcessPackagesListPackagesForOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesListPackagesForOrganizationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List packages for an organization<br/>
        /// Lists packages in an organization readable by the user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="org"></param>
        /// <param name="visibility"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Package>> PackagesListPackagesForOrganizationAsync(
            global::G.PackagesListPackagesForOrganizationPackageType packageType,
            string org,
            global::G.PackagesListPackagesForOrganizationVisibility? visibility = default,
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesListPackagesForOrganizationArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                org: ref org,
                visibility: ref visibility,
                page: ref page,
                perPage: ref perPage);

            var packageTypeValue = packageType switch
            {
                global::G.PackagesListPackagesForOrganizationPackageType.Npm => "npm",
                global::G.PackagesListPackagesForOrganizationPackageType.Maven => "maven",
                global::G.PackagesListPackagesForOrganizationPackageType.Rubygems => "rubygems",
                global::G.PackagesListPackagesForOrganizationPackageType.Docker => "docker",
                global::G.PackagesListPackagesForOrganizationPackageType.Nuget => "nuget",
                global::G.PackagesListPackagesForOrganizationPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var visibilityValue = visibility switch
            {
                global::G.PackagesListPackagesForOrganizationVisibility.Public => "public",
                global::G.PackagesListPackagesForOrganizationVisibility.Private => "private",
                global::G.PackagesListPackagesForOrganizationVisibility.Internal => "internal",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/packages",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("package_type", packageTypeValue.ToString()) 
                .AddOptionalParameter("visibility", visibilityValue?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesListPackagesForOrganizationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                org: org,
                visibility: visibility,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesListPackagesForOrganizationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPackagesListPackagesForOrganizationResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Package>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}