//HintName: G.IExamplesClient.CreateDatasetsByDatasetIdExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Upload Examples<br/>
        /// This endpoint allows clients to upload examples to a specified dataset by sending a multipart/form-data POST request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files associated with an example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByDatasetIdExamplesAsync(
            global::G.Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Examples<br/>
        /// This endpoint allows clients to upload examples to a specified dataset by sending a multipart/form-data POST request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files associated with an example.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example info as JSON. Can have fields 'metadata', 'split', 'use_source_run_io', 'source_run_id', 'created_at', 'modified_at'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// THe Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Attachments_name_">
        /// File attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachments_name_name">
        /// File attachment named {name}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetsByDatasetIdExamplesAsync(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[] x_exampleId_Inputs,
            string x_exampleId_Inputsname,
            byte[]? x_exampleId_Outputs = default,
            string? x_exampleId_Outputsname = default,
            byte[]? x_exampleId_Attachments_name_ = default,
            string? x_exampleId_Attachments_name_name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}