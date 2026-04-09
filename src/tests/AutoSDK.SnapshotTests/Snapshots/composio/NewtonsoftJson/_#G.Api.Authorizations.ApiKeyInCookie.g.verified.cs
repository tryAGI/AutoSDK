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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Cookie" &&
                    __authorization.Name == "authToken")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "CookieAuth",
                Location = "Cookie",
                Name = "authToken",
                Value = apiKey,
            });
        }
    }
}