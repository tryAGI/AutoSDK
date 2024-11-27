//HintName: G.IDescriptorClient.AddDescriptorField.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorField<br/>
        /// AddDescriptorField
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> AddDescriptorFieldAsync(
            global::G.AddDescriptorFieldRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDescriptorField<br/>
        /// AddDescriptorField
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="isDynamic"></param>
        /// <param name="setId"></param>
        /// <param name="fieldOptions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> AddDescriptorFieldAsync(
            global::System.Guid projectId,
            string title,
            string description,
            double type,
            bool isDynamic,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> fieldOptions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}