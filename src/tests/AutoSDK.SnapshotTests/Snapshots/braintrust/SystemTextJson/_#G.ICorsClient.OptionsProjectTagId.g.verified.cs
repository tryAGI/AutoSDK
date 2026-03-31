//HintName: G.ICorsClient.OptionsProjectTagId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/project_tag/{project_tag_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="projectTagId">
        /// ProjectTag id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsProjectTagIdAsync(
            global::System.Guid projectTagId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}