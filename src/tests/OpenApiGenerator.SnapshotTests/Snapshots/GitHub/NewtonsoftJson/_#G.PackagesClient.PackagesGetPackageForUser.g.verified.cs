﻿//HintName: G.PackagesClient.PackagesGetPackageForUser.g.cs

#nullable enable

namespace G
{
    public partial class PackagesClient
    {
        /// <summary>
        /// Get a package for a user
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Package> PackagesGetPackageForUserAsync(
            PackagesGetPackageForUserPackageType packageType,
            string packageName,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageTypeValue = packageType switch
            {
                PackagesGetPackageForUserPackageType.Npm => "npm",
                PackagesGetPackageForUserPackageType.Maven => "maven",
                PackagesGetPackageForUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageForUserPackageType.Docker => "docker",
                PackagesGetPackageForUserPackageType.Nuget => "nuget",
                PackagesGetPackageForUserPackageType.Container => "container",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/users/{username}/packages/{packageTypeValue}/{packageName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Package>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}