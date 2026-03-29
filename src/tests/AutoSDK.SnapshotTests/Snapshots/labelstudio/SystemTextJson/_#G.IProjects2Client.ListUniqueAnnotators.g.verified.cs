//HintName: G.IProjects2Client.ListUniqueAnnotators.g.cs
#nullable enable

namespace G
{
    public partial interface IProjects2Client
    {
        /// <summary>
        /// List unique annotators for project<br/>
        /// Return unique users who have submitted annotations in the specified project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserSimple>> ListUniqueAnnotatorsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}