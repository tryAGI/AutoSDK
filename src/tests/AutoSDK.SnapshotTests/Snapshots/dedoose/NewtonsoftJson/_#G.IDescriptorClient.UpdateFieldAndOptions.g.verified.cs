//HintName: G.IDescriptorClient.UpdateFieldAndOptions.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// UpdateFieldAndOptions<br/>
        /// UpdateFieldAndOptions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> UpdateFieldAndOptionsAsync(

            global::G.UpdateFieldAndOptionsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// UpdateFieldAndOptions<br/>
        /// UpdateFieldAndOptions
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="options"></param>
        /// <param name="deletedOptionIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> UpdateFieldAndOptionsAsync(
            global::System.Guid projectId,
            global::System.Guid fieldId,
            string title,
            string description,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> options,
            global::System.Collections.Generic.IList<global::System.Guid> deletedOptionIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}