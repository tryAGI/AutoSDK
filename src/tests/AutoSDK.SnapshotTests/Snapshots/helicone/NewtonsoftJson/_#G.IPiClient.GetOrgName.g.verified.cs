//HintName: G.IPiClient.GetOrgName.g.cs
#nullable enable

namespace G
{
    public partial interface IPiClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> GetOrgNameAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}