//HintName: G.IAnnotationsClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get all task annotations<br/>
        /// List all annotations for a task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Annotation>> ListAsync(
            int id,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}