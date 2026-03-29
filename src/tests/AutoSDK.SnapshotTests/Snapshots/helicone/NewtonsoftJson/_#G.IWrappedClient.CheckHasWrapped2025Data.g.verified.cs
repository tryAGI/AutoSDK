//HintName: G.IWrappedClient.CheckHasWrapped2025Data.g.cs
#nullable enable

namespace G
{
    public partial interface IWrappedClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHasDataBooleanString> CheckHasWrapped2025DataAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}