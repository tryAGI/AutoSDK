//HintName: G.IApi.OktaLoginOktaLoginGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Okta Login
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="origin"></param>
        /// <param name="loginId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OktaLoginOktaLoginGetAsync(
            string teamId,
            string? origin = default,
            string? loginId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}