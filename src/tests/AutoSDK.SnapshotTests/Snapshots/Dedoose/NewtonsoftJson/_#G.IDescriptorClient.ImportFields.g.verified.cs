//HintName: G.IDescriptorClient.ImportFields.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// ImportFields<br/>
        /// ImportFields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ImportFieldsAsync(
            global::G.ImportFieldsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ImportFields<br/>
        /// ImportFields
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ImportFieldsAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::G.FieldInfo> fieldInfos,
            global::System.Guid existingSetId,
            string newSetTitle,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}