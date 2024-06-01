//HintName: G.PackagesClient.PackagesGetAllPackageVersionsForPackageOwnedByUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// List package versions for a package owned by a user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByUserAsync(
            PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            string packageName,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/packages/{packageTypeValue}/{packageName}/versions", global::System.UriKind.RelativeOrAbsolute));

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