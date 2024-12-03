//HintName: G.IOpenAiClient.Authorizations.Bearer.g.cs

#nullable enable

namespace G
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey);
    }
}