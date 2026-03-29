//HintName: G.IDatasetsClient.DatasetReadV2EntityProjectDatasetsObjectIdVersionsDigestGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Read<br/>
        /// Get a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetReadRes> DatasetReadV2EntityProjectDatasetsObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}