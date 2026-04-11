//HintName: G.ITemplateClient.CreateApplicationsByApplicationIdJobs.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Generate from application (async)<br/>
        /// Generate content asynchronously from an existing no-code agent (formerly called no-code applications) with inputs.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/applications/{application_id}/jobs \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"inputs":[{"id": "Image ID", "value": ["12345"]}]}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GenerateApplicationAsyncResponse> CreateApplicationsByApplicationIdJobsAsync(
            string applicationId,

            global::G.GenerateApplicationAsyncRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate from application (async)<br/>
        /// Generate content asynchronously from an existing no-code agent (formerly called no-code applications) with inputs.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="inputs">
        /// A list of input objects to generate content for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateApplicationAsyncResponse> CreateApplicationsByApplicationIdJobsAsync(
            string applicationId,
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}