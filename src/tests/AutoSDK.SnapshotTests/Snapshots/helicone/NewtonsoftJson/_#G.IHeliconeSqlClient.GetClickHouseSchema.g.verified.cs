//HintName: G.IHeliconeSqlClient.GetClickHouseSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IHeliconeSqlClient
    {
        /// <summary>
        /// Get database schema<br/>
        /// Get ClickHouse schema (tables and columns)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultClickHouseTableSchemaArrayString> GetClickHouseSchemaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}