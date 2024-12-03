//HintName: G.IDescriptorClient.UpdateValues.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateValues<br/>
        /// UpdateValues
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateValuesAsync(
            global::G.UpdateValuesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateValues<br/>
        /// UpdateValues
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateValuesAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.DescriptorField> values,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}