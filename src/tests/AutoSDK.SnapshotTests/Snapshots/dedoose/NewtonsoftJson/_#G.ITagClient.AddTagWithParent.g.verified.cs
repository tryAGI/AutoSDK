//HintName: G.ITagClient.AddTagWithParent.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddTagWithParent<br/>
        /// AddTagWithParent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> AddTagWithParentAsync(

            global::G.AddTagWithParentRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AddTagWithParent<br/>
        /// AddTagWithParent
        /// </summary>
        /// <param name="proejctId"></param>
        /// <param name="parentTagId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
        /// <param name="color"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> AddTagWithParentAsync(
            global::System.Guid proejctId,
            global::System.Guid parentTagId,
            string title,
            string description,
            bool isWeighted,
            bool allowDecimalWeights,
            double color,
            double? weightMin = default,
            double? weightMax = default,
            double? weightDefault = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}