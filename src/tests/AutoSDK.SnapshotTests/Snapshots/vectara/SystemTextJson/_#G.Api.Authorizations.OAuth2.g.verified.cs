//HintName: G.Api.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken"></param>
        public async global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string scope,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            clientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            clientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));

            var response = await HttpClient.PostAsync(new global::System.Uri("AutoSDK.Models.EquatableArray`1[AutoSDK.Models.OAuthFlow]"), new global::System.Net.Http.FormUrlEncodedContent(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>
            {
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_id", clientId),
                new global::System.Collections.Generic.KeyValuePair<string, string>("client_secret", clientSecret),
                new global::System.Collections.Generic.KeyValuePair<string, string>("grant_type", "client_credentials"),
                new global::System.Collections.Generic.KeyValuePair<string, string>("scope", scope),
            })).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            var dictionary = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.Dictionary<string, string>>(json) ??
                             throw new global::System.InvalidOperationException("Deserialization failed.");

            var accessToken = dictionary["access_token"];

            Authorizations.Clear();
            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "OAuth2",
                Location = "Header",
                Name = "Bearer",
                Value = accessToken,
            });
        }
    }
}