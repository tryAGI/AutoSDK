﻿//HintName: G.IApi.DeleteVersionsModels.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a model version<br/>
        /// Delete a model version and all associated predictions, including all output files.<br/>
        /// Model version deletion has some restrictions:<br/>
        /// - You can only delete versions from models you own.<br/>
        /// - You can only delete versions from private models.<br/>
        /// - You cannot delete a version if someone other than you has run predictions with it.<br/>
        /// - You cannot delete a version if it is being used as the base model for a fine tune/training.<br/>
        /// - You cannot delete a version if it has an associated deployment.<br/>
        /// - You cannot delete a version if another model version is overridden to use it.<br/>
        /// Example cURL request:<br/>
        /// ```command<br/>
        /// curl -s -X DELETE \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa<br/>
        /// ```<br/>
        /// The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed.
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVersionsModelsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}