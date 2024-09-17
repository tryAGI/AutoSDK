//HintName: G.IDescriptorClient.DescriptorUpdateFieldAndOptions.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateFieldAndOptions.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="deletedOptionIds"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> DescriptorUpdateFieldAndOptionsAsync(
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request,
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? fieldId = default,
            string? title = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::System.Guid>? deletedOptionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}