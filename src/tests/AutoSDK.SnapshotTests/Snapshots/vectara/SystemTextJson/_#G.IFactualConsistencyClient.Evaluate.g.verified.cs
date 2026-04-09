//HintName: G.IFactualConsistencyClient.Evaluate.g.cs
#nullable enable

namespace G
{
    public partial interface IFactualConsistencyClient
    {
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.<br/>
        /// Use this API to programmatically validate generated content against trusted source materials—an essential capability for applications in high-integrity environments such as legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body must include the following parameters:<br/>
        /// * `model_parameters:` Optionally specifies the evaluation model to use. Default is `hhem_v2.2`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// * `language`: The ISO 639-3 code representing the language of the provided texts (`eng` for English, `fra` for French).<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ],<br/>
        ///   "language": "eng"<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a factual consistency score and probability estimates.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23,<br/>
        ///   "p_consistent": 0.12,<br/>
        ///   "p_inconsistent": 0.88<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.<br/>
        /// * `p_consistent`: The estimated probability that the generated text is factually consistent with the sources.<br/>
        /// * `p_inconsistent`: The estimated probability that the generated text contains factual inaccuracies relative to the source documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluateFactualConsistencyResponse> EvaluateAsync(

            global::G.EvaluateFactualConsistencyRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate factual consistency<br/>
        /// Evaluate the factual consistency of a generated text (like a summary) against source documents. This determines how accurately the generated text reflects the information in the source documents, helping identify potential hallucinations or misrepresentations.<br/>
        /// Use this API to programmatically validate generated content against trusted source materials—an essential capability for applications in high-integrity environments such as legal, healthcare, scientific publishing, and enterprise knowledge systems.<br/>
        /// The request body must include the following parameters:<br/>
        /// * `model_parameters:` Optionally specifies the evaluation model to use. Default is `hhem_v2.2`.<br/>
        /// * `generated_text`: The output text you want to evaluate, such as a model-generated summary, answer, or response.<br/>
        /// * `source_texts`: An array of source documents or passages used to verify the accuracy of the generated text.<br/>
        /// * `language`: The ISO 639-3 code representing the language of the provided texts (`eng` for English, `fra` for French).<br/>
        /// ### Example request<br/>
        /// This example evaluates whether a generated statement about the Eiffel Tower is factually accurate based on two reference documents.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "generated_text": "The Eiffel Tower is located in Berlin.",<br/>
        ///   "source_texts": [<br/>
        ///     "The Eiffel Tower is a famous landmark located in Paris, France.",<br/>
        ///     "It was built in 1889 and remains one of the most visited monuments in the world."<br/>
        ///   ],<br/>
        ///   "language": "eng"<br/>
        /// }<br/>
        /// ```<br/>
        /// ### Example response<br/>
        /// The response includes a factual consistency score and probability estimates.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "score": 0.23,<br/>
        ///   "p_consistent": 0.12,<br/>
        ///   "p_inconsistent": 0.88<br/>
        /// }<br/>
        /// ```<br/>
        /// * `score`: A normalized value between `0.0` and `1.0` that reflects the overall factual alignment between the generated text and the source texts. Higher scores indicate stronger consistency.<br/>
        /// * `p_consistent`: The estimated probability that the generated text is factually consistent with the sources.<br/>
        /// * `p_inconsistent`: The estimated probability that the generated text contains factual inaccuracies relative to the source documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="modelParameters">
        /// The model parameters for the evaluation.
        /// </param>
        /// <param name="generatedText">
        /// The generated text (e.g., summary or answer) to evaluate for factual consistency.
        /// </param>
        /// <param name="sourceTexts">
        /// The source documents or text snippets against which to evaluate factual consistency.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluateFactualConsistencyResponse> EvaluateAsync(
            string generatedText,
            global::System.Collections.Generic.IList<string> sourceTexts,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.EvaluateFactualConsistencyRequestModelParameters? modelParameters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}