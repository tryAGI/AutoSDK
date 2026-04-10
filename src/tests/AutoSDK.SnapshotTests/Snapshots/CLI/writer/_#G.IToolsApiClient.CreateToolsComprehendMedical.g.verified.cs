//HintName: G.IToolsApiClient.CreateToolsComprehendMedical.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Medical comprehend<br/>
        /// Analyze unstructured medical text to extract entities labeled with standardized medical codes and confidence scores.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/comprehend/medical \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"content":"the symptoms are soreness, a temperature and cough","response_type":"Entities"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.MedicalComprehendResponse> CreateToolsComprehendMedicalAsync(

            global::G.ComprehendMedicalRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Medical comprehend<br/>
        /// Analyze unstructured medical text to extract entities labeled with standardized medical codes and confidence scores.
        /// </summary>
        /// <param name="content">
        /// The text to analyze.
        /// </param>
        /// <param name="responseType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MedicalComprehendResponse> CreateToolsComprehendMedicalAsync(
            string content,
            global::G.ComprehendMedicalType responseType,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}