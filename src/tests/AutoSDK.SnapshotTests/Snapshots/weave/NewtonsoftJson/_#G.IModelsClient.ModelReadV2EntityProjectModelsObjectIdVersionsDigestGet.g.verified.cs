//HintName: G.IModelsClient.ModelReadV2EntityProjectModelsObjectIdVersionsDigestGet.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model Read<br/>
        /// Get a model object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelReadRes> ModelReadV2EntityProjectModelsObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}