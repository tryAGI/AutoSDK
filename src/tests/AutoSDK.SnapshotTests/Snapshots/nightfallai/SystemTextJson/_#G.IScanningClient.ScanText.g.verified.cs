//HintName: G.IScanningClient.ScanText.g.cs
#nullable enable

namespace G
{
    public partial interface IScanningClient
    {
        /// <summary>
        /// Scan text for sensitive data<br/>
        /// Scans the provided plaintext payloads against the provided detectors and returns all findings.<br/>
        /// Each index in the findings array corresponds one-to-one with the input request payload.<br/>
        /// Maximum 500KB total payload size. Maximum 50,000 items in the payload array.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScanTextResponse> ScanTextAsync(

            global::G.ScanTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scan text for sensitive data<br/>
        /// Scans the provided plaintext payloads against the provided detectors and returns all findings.<br/>
        /// Each index in the findings array corresponds one-to-one with the input request payload.<br/>
        /// Maximum 500KB total payload size. Maximum 50,000 items in the payload array.
        /// </summary>
        /// <param name="payload">
        /// List of text strings to scan. Maximum 50,000 items, 500KB total.
        /// </param>
        /// <param name="policy">
        /// Inline scan policy with detection rules and alert settings
        /// </param>
        /// <param name="policyUUIDs">
        /// UUIDs of pre-configured policies from the Nightfall Dashboard
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScanTextResponse> ScanTextAsync(
            global::System.Collections.Generic.IList<string> payload,
            global::G.ScanPolicy? policy = default,
            global::System.Collections.Generic.IList<string>? policyUUIDs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}