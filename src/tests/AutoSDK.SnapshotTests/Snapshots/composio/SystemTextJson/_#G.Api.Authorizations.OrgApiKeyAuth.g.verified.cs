//HintName: G.Api.Authorizations.OrgApiKeyAuth.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {

        /// <inheritdoc/>
        public void AuthorizeUsingOrgApiKeyAuth(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "x-org-api-key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "x-org-api-key",
                Value = apiKey,
            });
        }
    }
}