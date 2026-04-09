//HintName: G.IApi.Authorizations.Supabase1TokenAuth.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingSupabase1TokenAuth(
            string apiKey);
    }
}