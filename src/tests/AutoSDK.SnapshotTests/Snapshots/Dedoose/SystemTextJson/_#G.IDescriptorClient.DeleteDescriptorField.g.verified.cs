//HintName: G.IDescriptorClient.DeleteDescriptorField.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// DeleteDescriptorField<br/>
        /// DeleteDescriptorField
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorField> DeleteDescriptorFieldAsync(
            global::G.DeleteDescriptorFieldRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteDescriptorField<br/>
        /// DeleteDescriptorField
        /// </summary>
        /// <param name="field"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorField> DeleteDescriptorFieldAsync(
            global::G.DescriptorField field,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}