//HintName: G.IApi.Authorizations.Supabase2TeamAuth.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingSupabase2TeamAuth(
            string apiKey);
    }
}