//HintName: G.IRunsClient.CreateRunsMultipart.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.  \<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.  \<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.  \<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).  \<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).  \<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.  \<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.  \<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> CreateRunsMultipartAsync(
            global::G.Request3 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ingest Runs (Multipart)<br/>
        /// Ingests multiple runs, feedback objects, and binary attachments in a single `multipart/form-data` request.  \<br/>
        /// **Part‑name pattern**: `&lt;event&gt;.&lt;run_id&gt;[.&lt;field&gt;]` where `event` ∈ {`post`, `patch`, `feedback`, `attachment`}.  \<br/>
        /// * `post|patch.&lt;run_id&gt;` – JSON run payload.  \<br/>
        /// * `post|patch.&lt;run_id&gt;.&lt;field&gt;` – out‑of‑band run data (`inputs`, `outputs`, `events`, `error`, `extra`, `serialized`).  \<br/>
        /// * `feedback.&lt;run_id&gt;` – JSON feedback payload (must include `trace_id`).  \<br/>
        /// * `attachment.&lt;run_id&gt;.&lt;filename&gt;` – arbitrary binary attachment stored in S3.  \<br/>
        /// **Headers**: every part must set `Content-Type` **and** either a `Content-Length` header or `length` parameter. Per‑part `Content-Encoding` is **not** allowed; the top‑level request may be `Content-Encoding: zstd`.  \<br/>
        /// **Best performance** for high‑volume ingestion.
        /// </summary>
        /// <param name="post_runId_">
        /// Run to create (JSON)
        /// </param>
        /// <param name="post_runId_name">
        /// Run to create (JSON)
        /// </param>
        /// <param name="patch_runId_">
        /// Run to update (JSON)
        /// </param>
        /// <param name="patch_runId_name">
        /// Run to update (JSON)
        /// </param>
        /// <param name="post_runId_Inputs">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="post_runId_Inputsname">
        /// Large inputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputs">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="patch_runId_Outputsname">
        /// Large outputs object (JSON) stored out‑of‑band
        /// </param>
        /// <param name="feedback_runId_">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="feedback_runId_name">
        /// Feedback object (JSON) – must include trace_id
        /// </param>
        /// <param name="attachment_runId__filename_">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="attachment_runId__filename_name">
        /// Binary attachment linked to run {run_id}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> CreateRunsMultipartAsync(
            byte[]? post_runId_ = default,
            string? post_runId_name = default,
            byte[]? patch_runId_ = default,
            string? patch_runId_name = default,
            byte[]? post_runId_Inputs = default,
            string? post_runId_Inputsname = default,
            byte[]? patch_runId_Outputs = default,
            string? patch_runId_Outputsname = default,
            byte[]? feedback_runId_ = default,
            string? feedback_runId_name = default,
            byte[]? attachment_runId__filename_ = default,
            string? attachment_runId__filename_name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}