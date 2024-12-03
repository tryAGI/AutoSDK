//HintName: G.Api.Authorizations.ApiKeyInHeader.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Authorization",
                Value = apiKey,
            });
        }
    }
}