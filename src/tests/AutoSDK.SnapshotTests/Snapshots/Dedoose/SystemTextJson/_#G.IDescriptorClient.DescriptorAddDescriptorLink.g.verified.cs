//HintName: G.IDescriptorClient.DescriptorAddDescriptorLink.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorLink.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="dynamicValues"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorAddDescriptorLinkAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? resourceId = default,
            global::System.Guid? descriptorId = default,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO>? dynamicValues = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}