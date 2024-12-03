//HintName: G.IExcerptClient.UpdateImageExcerptRegion.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdateImageExcerptRegion<br/>
        /// UpdateImageExcerptRegion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateImageExcerptRegionAsync(
            global::G.UpdateImageExcerptRegionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateImageExcerptRegion<br/>
        /// UpdateImageExcerptRegion
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="excerptId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> UpdateImageExcerptRegionAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid excerptId,
            int start,
            int end,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}