//HintName: G.IProjectsClient.ApiProjectsValidateCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Validate label config<br/>
        /// Validate an arbitrary labeling configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiProjectsValidateCreateAsync(

            global::G.ProjectLabelConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate label config<br/>
        /// Validate an arbitrary labeling configuration.
        /// </summary>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ApiProjectsValidateCreateAsync(
            string labelConfig,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}