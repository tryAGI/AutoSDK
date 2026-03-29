//HintName: G.IDatabaseClient.GetDatabase.g.cs
#nullable enable

namespace G
{
    public partial interface IDatabaseClient
    {
        /// <summary>
        /// Get database<br/>
        /// Returns a database by name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Database> GetDatabaseAsync(
            string tenant,
            string database,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}