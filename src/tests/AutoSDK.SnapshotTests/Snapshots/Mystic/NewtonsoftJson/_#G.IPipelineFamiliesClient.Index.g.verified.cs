//HintName: G.IPipelineFamiliesClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFamiliesClient
    {
        /// <summary>
        /// Index<br/>
        /// List pipeline families.<br/>
        /// Depending on parameters this can mean all public families, or a user/team's<br/>
        /// specific families.<br/>
        /// Can also be ordered and filtered based on family name.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="orderBy">
        /// Default Value: popular
        /// </param>
        /// <param name="search"></param>
        /// <param name="includeAllRun">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedPipelineFamilyGet> IndexAsync(
            string? userId = default,
            string? teamId = default,
            global::G.AllOf<global::G.OrderBy?>? orderBy = default,
            string? search = default,
            bool? includeAllRun = default,
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}