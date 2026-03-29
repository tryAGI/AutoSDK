//HintName: G.IProjects2Client.ValidateLabelConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// Validate project label config<br/>
        /// Determine whether the label configuration for a specific project is valid.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectLabelConfig> ValidateLabelConfigAsync(
            int id,

            global::G.ProjectLabelConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate project label config<br/>
        /// Determine whether the label configuration for a specific project is valid.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectLabelConfig> ValidateLabelConfigAsync(
            int id,
            string labelConfig,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}