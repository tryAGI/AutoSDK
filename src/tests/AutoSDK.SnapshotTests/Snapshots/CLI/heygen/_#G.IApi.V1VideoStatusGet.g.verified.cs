//HintName: G.IApi.V1VideoStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// v1/video_status.get<br/>
        /// v1/video_status.get
        /// </summary>
        /// <param name="videoId">
        /// Example: &lt;video_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1VideoStatusGetAsync(
            string? videoId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}