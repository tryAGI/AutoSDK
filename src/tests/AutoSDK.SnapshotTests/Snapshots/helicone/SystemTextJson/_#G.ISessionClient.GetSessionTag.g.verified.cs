//HintName: G.ISessionClient.GetSessionTag.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringOrNullString> GetSessionTagAsync(
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}