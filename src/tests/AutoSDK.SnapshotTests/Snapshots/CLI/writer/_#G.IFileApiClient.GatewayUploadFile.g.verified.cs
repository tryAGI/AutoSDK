//HintName: G.IFileApiClient.GatewayUploadFile.g.cs
#nullable enable

namespace G
{
    public partial interface IFileApiClient
    {
        /// <summary>
        /// Upload file<br/>
        /// Upload a new file to the system. Supports various file formats including PDF, DOC, DOCX, PPT, PPTX, JPG, PNG, EML, HTML, SRT, CSV, XLS, and XLSX.
        /// </summary>
        /// <param name="contentDisposition"></param>
        /// <param name="contentType"></param>
        /// <param name="contentLength"></param>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/files \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"<br/>
        ///  --header "Accept: */*" \<br/>
        ///  --header "Content-Disposition: attachment; filename=descriptions.pdf" \<br/>
        ///  --header "Content-Length: size_in_bytes" \<br/>
        ///  --header "Content-Type: application/pdf" \<br/>
        ///  --data-binary "@descriptions.pdf"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.FileResponse> GatewayUploadFileAsync(
            string contentDisposition,
            string contentType,
            long contentLength,

            byte[] request,
            global::System.Guid? graphId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}