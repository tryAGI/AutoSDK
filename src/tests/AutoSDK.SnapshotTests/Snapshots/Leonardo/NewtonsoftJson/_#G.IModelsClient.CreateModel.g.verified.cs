//HintName: G.IModelsClient.CreateModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Train a Custom Model<br/>
        /// This endpoint will train a new custom model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(
            global::G.CreateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Train a Custom Model<br/>
        /// This endpoint will train a new custom model
        /// </summary>
        /// <param name="name">
        /// The name of the model.
        /// </param>
        /// <param name="description">
        /// The description of the model.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the model on.
        /// </param>
        /// <param name="instancePrompt">
        /// The instance prompt to use during training.
        /// </param>
        /// <param name="modelType">
        /// The category the most accurately reflects the model.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="nsfw">
        /// Whether or not the model is NSFW.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolution">
        /// The resolution for training. Must be 512 or 768.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="strength">
        /// When training using the PIXEL_ART model type, this influences the training strength.<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(
            string name,
            string datasetId,
            string instancePrompt,
            string? description = default,
            global::G.CustomModelType? modelType = default,
            bool? nsfw = default,
            int? resolution = default,
            global::G.SdVersions? sdVersion = default,
            global::G.Strength? strength = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}