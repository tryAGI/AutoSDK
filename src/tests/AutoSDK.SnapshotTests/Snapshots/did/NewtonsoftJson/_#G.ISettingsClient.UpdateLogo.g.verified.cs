//HintName: G.ISettingsClient.UpdateLogo.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Upload logo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateLogoAsync(

            global::G.UpdateLogoRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload logo
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="logoname"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateLogoAsync(
            byte[] logo,
            string logoname,
            string top,
            string left,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}