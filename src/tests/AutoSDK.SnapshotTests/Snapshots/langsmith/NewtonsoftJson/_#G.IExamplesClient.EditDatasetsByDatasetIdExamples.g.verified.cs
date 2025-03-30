//HintName: G.IExamplesClient.EditDatasetsByDatasetIdExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Examples<br/>
        /// This endpoint allows clients to update existing examples in a specified dataset by sending a multipart/form-data PATCH request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files to update an example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EditDatasetsByDatasetIdExamplesAsync(
            global::G.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Examples<br/>
        /// This endpoint allows clients to update existing examples in a specified dataset by sending a multipart/form-data PATCH request.<br/>
        /// Each form part contains either JSON-encoded data or binary attachment files to update an example.
        /// </summary>
        /// <param name="x_exampleId_">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_name">
        /// The Example update info as JSON. Can have fields 'metadata', 'split'
        /// </param>
        /// <param name="x_exampleId_Inputs">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Inputsname">
        /// The updated Example inputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputs">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_Outputsname">
        /// The updated Example outputs as JSON
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperations">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_AttachmentsOperationsname">
        /// JSON describing attachment operations (retain, rename)
        /// </param>
        /// <param name="x_exampleId_Attachment_name_">
        /// New file attachment named {name}
        /// </param>
        /// <param name="x_exampleId_Attachment_name_name">
        /// New file attachment named {name}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditDatasetsByDatasetIdExamplesAsync(
            byte[] x_exampleId_,
            string x_exampleId_name,
            byte[]? x_exampleId_Inputs = default,
            string? x_exampleId_Inputsname = default,
            byte[]? x_exampleId_Outputs = default,
            string? x_exampleId_Outputsname = default,
            byte[]? x_exampleId_AttachmentsOperations = default,
            string? x_exampleId_AttachmentsOperationsname = default,
            byte[]? x_exampleId_Attachment_name_ = default,
            string? x_exampleId_Attachment_name_name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}