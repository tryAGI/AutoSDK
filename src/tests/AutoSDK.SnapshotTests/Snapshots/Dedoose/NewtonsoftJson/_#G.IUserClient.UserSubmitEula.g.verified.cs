//HintName: G.IUserClient.UserSubmitEula.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// SubmitEula.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserSubmitEulaAsync(
            string? token = default,
            global::System.Guid? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}