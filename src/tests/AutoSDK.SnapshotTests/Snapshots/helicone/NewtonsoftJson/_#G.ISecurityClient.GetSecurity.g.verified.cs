//HintName: G.ISecurityClient.GetSecurity.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultUnsafeBooleanString> GetSecurityAsync(

            global::G.GetSecurityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="advanced"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultUnsafeBooleanString> GetSecurityAsync(
            string text,
            bool advanced,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}