//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByOrg.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// List package versions for a package owned by an organization
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="org"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesGetAllPackageVersionsForPackageOwnedByOrgAsync(
            PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int page,
            int perPage,
            PackagesGetAllPackageVersionsForPackageOwnedByOrgState state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Active => "active",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgState.Deleted => "deleted",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/packages/{packageTypeValue}/{packageName}/versions?page={page}&per_page={perPage}&state={stateValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}