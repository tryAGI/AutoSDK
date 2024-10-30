//HintName: G.IModelClient.ModelPublicServiceGetModelDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Get a model definition<br/>
        /// Returns the details of a model definition.
        /// </summary>
        /// <param name="modelDefinitionId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelDefinitionResponse> ModelPublicServiceGetModelDefinitionAsync(
            string modelDefinitionId,
            global::G.ModelPublicServiceGetModelDefinitionView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}