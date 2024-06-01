//HintName: G.PackagesClient.PackagesRestorePackageVersionForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Restore a package version for the authenticated user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<BasicError> PackagesRestorePackageVersionForAuthenticatedUserAsync(
            PackagesRestorePackageVersionForAuthenticatedUserPackageType packageType,
            string packageName,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/packages/{packageTypeValue}/{packageName}/versions/{packageVersionId}/restore", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<BasicError?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}