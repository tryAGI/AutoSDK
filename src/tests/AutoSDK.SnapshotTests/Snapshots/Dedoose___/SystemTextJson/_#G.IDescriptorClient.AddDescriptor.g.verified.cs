//HintName: G.IDescriptorClient.AddDescriptor.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptor<br/>
        /// AddDescriptor
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorWithValues> AddDescriptorAsync(
            global::G.AddDescriptorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDescriptor<br/>
        /// AddDescriptor
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldValues"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorWithValues> AddDescriptorAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> fieldValues,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}