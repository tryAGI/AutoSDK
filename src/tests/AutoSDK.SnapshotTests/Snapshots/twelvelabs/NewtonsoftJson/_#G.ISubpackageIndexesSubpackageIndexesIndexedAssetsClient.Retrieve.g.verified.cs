//HintName: G.ISubpackageIndexesSubpackageIndexesIndexedAssetsClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Retrieve indexed asset information<br/>
        /// This method retrieves information about an indexed asset, including its status, metadata, and optional embeddings or transcription.<br/>
        /// Use this method to:<br/>
        /// - Monitor the indexing progress:<br/>
        ///     - Call this endpoint after creating an indexed asset<br/>
        ///     - Check the `status` field until it shows `ready`<br/>
        ///     - Once ready, your content is available for search and analysis<br/>
        /// - Retrieve the asset metadata:<br/>
        ///     - Retrieve system metadata (duration, resolution, filename)<br/>
        ///     - Access user-defined metadata<br/>
        /// - Retrieve the embeddings:<br/>
        ///     - Include the `embeddingOption` parameter to retrieve video embeddings<br/>
        ///     - Requires the Marengo video understanding model to be enabled in your index<br/>
        /// - Retrieve transcriptions:<br/>
        ///   - Set the `transcription` parameter to `true` to retrieve spoken words from your video
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="embeddingOption"></param>
        /// <param name="transcription"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexedAssetDetailed> RetrieveAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption = default,
            bool? transcription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}