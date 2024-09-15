//HintName: G.IDescriptorClient.DescriptorAddOrUpdateDynamicValues.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddOrUpdateDynamicValues.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorAddOrUpdateDynamicValuesResponse> DescriptorAddOrUpdateDynamicValuesAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid resourceId = default,
            global::System.Guid setId = default,
            global::System.Guid descriptorId = default,
            global::System.Collections.Generic.IList<global::G.DynamicDescriptorValueDTO>? values = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}