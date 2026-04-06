//HintName: G.Api.Authorizations.ApiKeyInCookie.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInCookie(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Cookie",
                Name = "access-token",
                Value = apiKey,
            });
        }
    }
}