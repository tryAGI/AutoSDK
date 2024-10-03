//HintName: G.ISchemaClient.SchemaObjectsGet.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Get a single collection schema.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsGetAsync(
            string className,
            bool? consistency = true,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}