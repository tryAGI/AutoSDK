//HintName: G.IGenerationApiClient.GenerateContentAsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationApiClient
    {
        /// <summary>
        /// Generate from application<br/>
        /// Generate content from an existing no-code agent (formerly called no-code applications) with inputs.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/applications/{application_id} \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"inputs":[{"id": "Image ID", "value": ["12345"]}]}'
        /// </remarks>
        global::System.Collections.Generic.IAsyncEnumerable<global::System.Collections.Generic.IList<global::G.GenerateApplicationResponseChunk>> GenerateContentAsStreamAsync(
            global::System.Guid applicationId,

            global::G.GenerateApplicationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate from application<br/>
        /// Generate content from an existing no-code agent (formerly called no-code applications) with inputs.
        /// </summary>
        /// <param name="applicationId"></param>
        /// <param name="inputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::System.Collections.Generic.IList<global::G.GenerateApplicationResponseChunk>> GenerateContentAsStreamAsync(
            global::System.Guid applicationId,
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}