//HintName: G.IWaitlistClient.GetWaitlistCount.g.cs
#nullable enable

namespace G
{
    public partial interface IWaitlistClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultCountNumberString> GetWaitlistCountAsync(
            string feature,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}