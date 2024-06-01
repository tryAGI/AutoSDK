//HintName: G.PackagesClient.PackagesGetPackageVersionForUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Get a package version for a user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PackageVersion> PackagesGetPackageVersionForUserAsync(
            PackagesGetPackageVersionForUserPackageType packageType,
            string packageName,
            int packageVersionId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetPackageVersionForUserPackageType.Npm => "npm",
                PackagesGetPackageVersionForUserPackageType.Maven => "maven",
                PackagesGetPackageVersionForUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageVersionForUserPackageType.Docker => "docker",
                PackagesGetPackageVersionForUserPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/packages/{packageTypeValue}/{packageName}/versions/{packageVersionId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<PackageVersion?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}