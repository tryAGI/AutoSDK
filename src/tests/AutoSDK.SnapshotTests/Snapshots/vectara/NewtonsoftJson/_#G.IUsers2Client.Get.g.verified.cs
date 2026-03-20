//HintName: G.IUsers2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IUsers2Client
    {
        /// <summary>
        /// Get a user<br/>
        /// Get a user and view details like the email, username, and associated roles.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> GetAsync(
            string username,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}