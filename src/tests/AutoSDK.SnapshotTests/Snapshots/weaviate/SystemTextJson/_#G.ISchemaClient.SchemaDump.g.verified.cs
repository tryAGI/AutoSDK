//HintName: G.ISchemaClient.SchemaDump.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get the entire schema.<br/>
        /// Fetch an array of all collection definitions from the schema.
        /// </summary>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Schema> SchemaDumpAsync(
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}