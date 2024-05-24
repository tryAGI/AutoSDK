//HintName: G.PackagesClient.PackagesRestorePackageForUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Restore a package for a user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PackagesRestorePackageForUserAsync(
            PackagesRestorePackageForUserPackageType packageType,
            string packageName,
            string username,
            string token,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesRestorePackageForUserPackageType.Npm => "npm",
                PackagesRestorePackageForUserPackageType.Maven => "maven",
                PackagesRestorePackageForUserPackageType.Rubygems => "rubygems",
                PackagesRestorePackageForUserPackageType.Docker => "docker",
                PackagesRestorePackageForUserPackageType.Nuget => "nuget",
                PackagesRestorePackageForUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/packages/{packageTypeValue}/{packageName}/restore?token={token}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}