//HintName: G.ICloudClient.ListRegions.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// List Regions<br/>
        /// Get all the available regions under a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RegionGet>> ListRegionsAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}