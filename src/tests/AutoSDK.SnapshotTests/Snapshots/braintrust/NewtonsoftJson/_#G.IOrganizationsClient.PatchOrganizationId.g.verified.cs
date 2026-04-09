//HintName: G.IOrganizationsClient.PatchOrganizationId.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Partially update organization<br/>
        /// Partially update an organization object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="organizationId">
        /// Organization id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Organization> PatchOrganizationIdAsync(
            global::System.Guid organizationId,

            global::G.PatchOrganization request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update organization<br/>
        /// Partially update an organization object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="organizationId">
        /// Organization id
        /// </param>
        /// <param name="name">
        /// Name of the organization
        /// </param>
        /// <param name="apiUrl"></param>
        /// <param name="isUniversalApi"></param>
        /// <param name="isDataplanePrivate"></param>
        /// <param name="proxyUrl"></param>
        /// <param name="realtimeUrl"></param>
        /// <param name="imageRenderingMode">
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Organization> PatchOrganizationIdAsync(
            global::System.Guid organizationId,
            string? name = default,
            string? apiUrl = default,
            bool? isUniversalApi = default,
            bool? isDataplanePrivate = default,
            string? proxyUrl = default,
            string? realtimeUrl = default,
            global::G.ImageRenderingMode? imageRenderingMode = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}