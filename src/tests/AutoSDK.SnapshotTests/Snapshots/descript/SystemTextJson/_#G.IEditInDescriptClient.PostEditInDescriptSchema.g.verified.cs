//HintName: G.IEditInDescriptClient.PostEditInDescriptSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IEditInDescriptClient
    {
        /// <summary>
        /// Create Import URL<br/>
        /// Create an Import URL by sending a Project schema to Descript API from your service's backend.<br/>
        /// ### Import Schema<br/>
        /// Our import schemas are specified as a minimal JSON list of files which is detailed in full at the bottom of this<br/>
        /// section. At it's smallest, the request body looks like:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "partner_drive_id": "162c61d1-6ced-4b25-a622-7dba922983ee",<br/>
        ///   "project_schema": {<br/>
        ///     "schema_version": "1.0.0",<br/>
        ///     "files": [{"uri": "https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955"}]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### File Access<br/>
        /// The file paths provided in the schema need to either be public or pre-signed URIs with enough time before<br/>
        /// expiration for failures and retries, we suggest URIs that won't expire for 48 hours. We ask that the files have<br/>
        /// already been saved when the import link is generated to minimize cases where we're waiting for eventually<br/>
        /// consistent storage of files that will never be written. We will, however, wait for eventual consistency of the<br/>
        /// storage layer and retry fetching files before eventually timing out.<br/>
        /// Files must be hosted on preapproved hosts as our import process has an allow list which it checks URIs against.<br/>
        /// Files will be requested with `User-Agent: Descriptbot/1.0` (version may change) for tracking purposes.<br/>
        /// ### Import link expiration<br/>
        /// Import links are no longer valid after a user imports their data once. Viewing an already used import link will<br/>
        /// not allow for importing again and will not provide access to a previously created Descript Project. Partners are<br/>
        /// able to generate a new import link at any time, regardless of if a previous import link has been used.<br/>
        /// The API does not currently provide partners with a link to the Descript Project, though users will be redirected<br/>
        /// to it from Descript's web interface the first time they import files, and can always find the Project in Descript.<br/>
        /// Import links expire after 3 hours and attempting to use an import link after the pre-signed links in the schema<br/>
        /// file have expired will result in an error, so we recommend generating the import link after the user has clicked<br/>
        /// the Edit in Descript button.<br/>
        /// ### Supported media specification<br/>
        /// We recommend sending the highest quality, uncompressed versions of files available to you. If you have multiple<br/>
        /// tracks, we recommend prioritizing sending us the full multi-track sequence over a combined file.<br/>
        /// * Audio: WAV, FLAC, AAC, MP3<br/>
        /// * Video: h264, HEVC (container: MOV, MP4)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EditInDescriptSchemaPostResponse> PostEditInDescriptSchemaAsync(

            global::G.EditInDescriptSchemaPostBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Import URL<br/>
        /// Create an Import URL by sending a Project schema to Descript API from your service's backend.<br/>
        /// ### Import Schema<br/>
        /// Our import schemas are specified as a minimal JSON list of files which is detailed in full at the bottom of this<br/>
        /// section. At it's smallest, the request body looks like:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "partner_drive_id": "162c61d1-6ced-4b25-a622-7dba922983ee",<br/>
        ///   "project_schema": {<br/>
        ///     "schema_version": "1.0.0",<br/>
        ///     "files": [{"uri": "https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955"}]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### File Access<br/>
        /// The file paths provided in the schema need to either be public or pre-signed URIs with enough time before<br/>
        /// expiration for failures and retries, we suggest URIs that won't expire for 48 hours. We ask that the files have<br/>
        /// already been saved when the import link is generated to minimize cases where we're waiting for eventually<br/>
        /// consistent storage of files that will never be written. We will, however, wait for eventual consistency of the<br/>
        /// storage layer and retry fetching files before eventually timing out.<br/>
        /// Files must be hosted on preapproved hosts as our import process has an allow list which it checks URIs against.<br/>
        /// Files will be requested with `User-Agent: Descriptbot/1.0` (version may change) for tracking purposes.<br/>
        /// ### Import link expiration<br/>
        /// Import links are no longer valid after a user imports their data once. Viewing an already used import link will<br/>
        /// not allow for importing again and will not provide access to a previously created Descript Project. Partners are<br/>
        /// able to generate a new import link at any time, regardless of if a previous import link has been used.<br/>
        /// The API does not currently provide partners with a link to the Descript Project, though users will be redirected<br/>
        /// to it from Descript's web interface the first time they import files, and can always find the Project in Descript.<br/>
        /// Import links expire after 3 hours and attempting to use an import link after the pre-signed links in the schema<br/>
        /// file have expired will result in an error, so we recommend generating the import link after the user has clicked<br/>
        /// the Edit in Descript button.<br/>
        /// ### Supported media specification<br/>
        /// We recommend sending the highest quality, uncompressed versions of files available to you. If you have multiple<br/>
        /// tracks, we recommend prioritizing sending us the full multi-track sequence over a combined file.<br/>
        /// * Audio: WAV, FLAC, AAC, MP3<br/>
        /// * Video: h264, HEVC (container: MOV, MP4)
        /// </summary>
        /// <param name="partnerDriveId">
        /// The drive id associated with the auth token.<br/>
        /// Example: aa3b2d8d-e5ca-41c2-8801-683328293fb9
        /// </param>
        /// <param name="projectSchema">
        /// The Project schema
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EditInDescriptSchemaPostResponse> PostEditInDescriptSchemaAsync(
            global::System.Guid partnerDriveId,
            global::G.EditInDescriptSchemaPostBodyProjectSchema projectSchema,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}