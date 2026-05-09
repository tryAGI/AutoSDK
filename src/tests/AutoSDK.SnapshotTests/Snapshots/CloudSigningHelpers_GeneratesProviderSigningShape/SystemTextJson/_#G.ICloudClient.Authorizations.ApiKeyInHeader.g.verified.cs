//HintName: G.ICloudClient.Authorizations.ApiKeyInHeader.g.cs

#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}