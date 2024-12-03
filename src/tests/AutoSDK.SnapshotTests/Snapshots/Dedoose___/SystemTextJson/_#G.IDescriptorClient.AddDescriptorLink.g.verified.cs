//HintName: G.IDescriptorClient.AddDescriptorLink.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorLink<br/>
        /// AddDescriptorLink
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddDescriptorLinkAsync(
            global::G.AddDescriptorLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDescriptorLink<br/>
        /// AddDescriptorLink
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="dynamicValues"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddDescriptorLinkAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> dynamicValues,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}