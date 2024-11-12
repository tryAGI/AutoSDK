//HintName: G.IClassificationClient.TrainV1TrainPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassificationClient
    {
        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingOutput> TrainV1TrainPostAsync(
            global::G.TrainingAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="classifierId">
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="visibility">
        /// The visibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
        /// Default Value: public
        /// </param>
        /// <param name="input">
        /// List of text and images and labels or a single text and image and label to train the classifier
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingOutput> TrainV1TrainPostAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> input,
            string? model = default,
            string? classifierId = default,
            global::G.TrainingAPIInputVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}