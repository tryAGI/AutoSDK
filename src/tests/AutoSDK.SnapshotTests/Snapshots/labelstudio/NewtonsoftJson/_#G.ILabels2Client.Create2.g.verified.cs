//HintName: G.ILabels2Client.Create2.g.cs
#nullable enable

namespace G
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// Create labels<br/>
        /// Add labels to your project without updating the labeling configuration.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLabelCreateList> Create2Async(

            global::System.Collections.Generic.IList<global::G.LabelCreateRequest> request,
            string? ordering = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}