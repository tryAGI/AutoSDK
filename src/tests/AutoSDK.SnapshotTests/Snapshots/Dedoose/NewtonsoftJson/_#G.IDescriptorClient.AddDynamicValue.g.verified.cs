//HintName: G.IDescriptorClient.AddDynamicValue.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDynamicValue<br/>
        /// AddDynamicValue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddDynamicValueAsync(
            global::G.AddDynamicValueRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDynamicValue<br/>
        /// AddDynamicValue
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="optionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddDynamicValueAsync(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Guid descriptorId,
            global::System.Guid fieldId,
            global::System.Guid resourceId,
            string data,
            global::System.Guid optionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}