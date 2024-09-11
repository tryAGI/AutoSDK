//HintName: G.Api.Authorizations..g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKey(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }
    }
}