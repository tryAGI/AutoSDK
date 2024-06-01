//HintName: G.PackagesClient.PackagesListPackagesForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// List packages for the authenticated user's namespace
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="visibility"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Package>> PackagesListPackagesForAuthenticatedUserAsync(
            PackagesListPackagesForAuthenticatedUserPackageType packageType,
            PackagesListPackagesForAuthenticatedUserVisibility visibility,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesListPackagesForAuthenticatedUserPackageType.Npm => "npm",
                PackagesListPackagesForAuthenticatedUserPackageType.Maven => "maven",
                PackagesListPackagesForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesListPackagesForAuthenticatedUserPackageType.Docker => "docker",
                PackagesListPackagesForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesListPackagesForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var visibilityValue = visibility switch
            {
                PackagesListPackagesForAuthenticatedUserVisibility.Public => "public",
                PackagesListPackagesForAuthenticatedUserVisibility.Private => "private",
                PackagesListPackagesForAuthenticatedUserVisibility.Internal => "internal",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/packages?package_type={packageTypeValue}&visibility={visibilityValue}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Package>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}