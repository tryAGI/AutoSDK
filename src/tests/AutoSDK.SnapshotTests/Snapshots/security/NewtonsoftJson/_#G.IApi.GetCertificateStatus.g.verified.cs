//HintName: G.IApi.GetCertificateStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Checks mutual TLS certificate status
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCertificateStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}