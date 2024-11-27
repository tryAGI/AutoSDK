//HintName: G.IUserClient.SubmitEula.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// SubmitEula<br/>
        /// SubmitEula
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitEulaAsync(
            global::G.SubmitEulaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SubmitEula<br/>
        /// SubmitEula
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitEulaAsync(
            global::System.Guid userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}