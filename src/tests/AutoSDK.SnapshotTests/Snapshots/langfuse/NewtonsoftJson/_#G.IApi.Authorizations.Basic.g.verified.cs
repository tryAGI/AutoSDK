//HintName: G.IApi.Authorizations.Basic.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using basic authentication.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void AuthorizeUsingBasic(
            string username,
            string password);
    }
}