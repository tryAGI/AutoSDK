//HintName: G.IUserClient.GetUserSelf.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get user information<br/>
        /// This endpoint will return your user information such as your user id, username, token renewal date and current amounts of the following: subscription tokens, gpt (prompt generation) tokens, and model training tokens
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserSelfResponse> GetUserSelfAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}