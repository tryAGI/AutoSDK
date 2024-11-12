//HintName: G.IDescriptorClient.DescriptorImportFields.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// ImportFields.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorImportFieldsAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            global::System.Collections.Generic.IList<global::G.FieldInfo>? fieldInfos = default,
            global::System.Guid? existingSetId = default,
            string? newSetTitle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}