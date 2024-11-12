//HintName: G.IDescriptorClient.DescriptorForceDeleteDescriptorSetPolled.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// ForceDeleteDescriptorSetPolled.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorForceDeleteDescriptorSetPolledAsync(
            string? token = default,
            global::System.Guid? projectIDL = default,
            global::System.Guid? descriptorSetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}