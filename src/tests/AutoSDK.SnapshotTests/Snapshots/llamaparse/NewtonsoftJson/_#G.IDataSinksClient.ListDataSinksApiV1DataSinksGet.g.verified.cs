//HintName: G.IDataSinksClient.ListDataSinksApiV1DataSinksGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSinksClient
    {
        /// <summary>
        /// List Data Sinks<br/>
        /// List data sinks for a given project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DataSink>> ListDataSinksApiV1DataSinksGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}