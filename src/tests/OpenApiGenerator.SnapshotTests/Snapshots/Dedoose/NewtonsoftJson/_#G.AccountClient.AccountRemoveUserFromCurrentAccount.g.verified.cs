﻿//HintName: G.AccountClient.AccountRemoveUserFromCurrentAccount.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        /// <summary>
        /// RemoveUserFromCurrentAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.User> AccountRemoveUserFromCurrentAccountAsync(
            string token,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/api/v1/account/removeuserfromcurrentaccount?userId={userId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.User?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}