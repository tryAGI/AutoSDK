//HintName: G.IVisionClient.CreateVision.g.cs
#nullable enable

namespace G
{
    public partial interface IVisionClient
    {
        /// <summary>
        /// Analyze images<br/>
        /// Submit images and documents with a prompt to generate an analysis. Supports JPG, PNG, PDF, and TXT files up to 7MB each.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/vision \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"model":"palmyra-vision","variables":[{"name":"image_1","file_id":"f1234"},{"name":"image_2","file_id":"f9876"}],"prompt":"Describe the difference between the image {{image_1}} and the image {{image_2}}."}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.VisionResponse> CreateVisionAsync(

            global::G.VisionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze images<br/>
        /// Submit images and documents with a prompt to generate an analysis. Supports JPG, PNG, PDF, and TXT files up to 7MB each.
        /// </summary>
        /// <param name="model">
        /// The model to use for image analysis.
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for the image analysis. The prompt must include the name of each image variable, surrounded by double curly braces (`{{}}`). For example, `Describe the difference between the image {{image_1}} and the image {{image_2}}`.
        /// </param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VisionResponse> CreateVisionAsync(
            string prompt,
            global::System.Collections.Generic.IList<global::G.VisionRequestFileVariable> variables,
            global::G.VisionRequestModel model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}