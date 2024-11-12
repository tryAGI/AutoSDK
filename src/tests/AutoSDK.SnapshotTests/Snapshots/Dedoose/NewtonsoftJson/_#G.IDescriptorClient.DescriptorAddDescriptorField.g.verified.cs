//HintName: G.IDescriptorClient.DescriptorAddDescriptorField.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDescriptorField.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="isDynamic"></param>
        /// <param name="setId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> DescriptorAddDescriptorFieldAsync(
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request,
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            string? description = default,
            double? type = default,
            bool? isDynamic = default,
            global::System.Guid? setId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}