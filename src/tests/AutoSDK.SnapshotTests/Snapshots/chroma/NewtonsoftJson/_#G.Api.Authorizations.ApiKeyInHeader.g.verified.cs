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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-chroma-token")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApiKeyAuth",
                Location = "Header",
                Name = "x-chroma-token",
                Value = apiKey,
            });
        }
    }
}