//HintName: G.CloudClient.Authorizations.ApiKeyInHeader.g.cs

#nullable enable

namespace G
{
    public sealed partial class CloudClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "AzureApiKey",
                Location = "Header",
                Name = "api-key",
                Value = apiKey,
            });
        }
    }
}