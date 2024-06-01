//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// List package versions for a package owned by the authenticated user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserAsync(
            PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            string packageName,
            int page,
            int perPage,
            PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Active => "active",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState.Deleted => "deleted",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/packages/{packageTypeValue}/{packageName}/versions?page={page}&per_page={perPage}&state={stateValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<PackageVersion>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}