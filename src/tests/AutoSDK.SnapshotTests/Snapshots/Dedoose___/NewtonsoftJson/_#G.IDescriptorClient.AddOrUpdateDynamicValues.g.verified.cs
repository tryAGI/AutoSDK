//HintName: G.IDescriptorClient.AddOrUpdateDynamicValues.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddOrUpdateDynamicValues<br/>
        /// AddOrUpdateDynamicValues
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddOrUpdateDynamicValuesAsync(
            global::G.AddOrUpdateDynamicValuesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddOrUpdateDynamicValues<br/>
        /// AddOrUpdateDynamicValues
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddOrUpdateDynamicValuesAsync(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid setId,
            global::System.Guid descriptorId,
            global::System.Collections.Generic.IList<global::G.DynamicDescriptorValueDTO> values,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}