//HintName: G.Api.Authorizations.ApiKeyInQuery.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Query",
                Name = "key",
                Value = apiKey,
            });
        }
    }
}