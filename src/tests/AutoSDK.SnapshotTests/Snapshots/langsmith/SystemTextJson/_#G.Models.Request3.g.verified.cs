//HintName: G.Models.Request3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request3
    {
        /// <summary>
        /// Run to create (JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post.{run_id}")]
        public byte[]? Post_runId_ { get; set; }

        /// <summary>
        /// Run to create (JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post.{run_id}name")]
        public string? Post_runId_name { get; set; }

        /// <summary>
        /// Run to update (JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch.{run_id}")]
        public byte[]? Patch_runId_ { get; set; }

        /// <summary>
        /// Run to update (JSON)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch.{run_id}name")]
        public string? Patch_runId_name { get; set; }

        /// <summary>
        /// Large inputs object (JSON) stored out‑of‑band
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post.{run_id}.inputs")]
        public byte[]? Post_runId_Inputs { get; set; }

        /// <summary>
        /// Large inputs object (JSON) stored out‑of‑band
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post.{run_id}.inputsname")]
        public string? Post_runId_Inputsname { get; set; }

        /// <summary>
        /// Large outputs object (JSON) stored out‑of‑band
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch.{run_id}.outputs")]
        public byte[]? Patch_runId_Outputs { get; set; }

        /// <summary>
        /// Large outputs object (JSON) stored out‑of‑band
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch.{run_id}.outputsname")]
        public string? Patch_runId_Outputsname { get; set; }

        /// <summary>
        /// Feedback object (JSON) – must include trace_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback.{run_id}")]
        public byte[]? Feedback_runId_ { get; set; }

        /// <summary>
        /// Feedback object (JSON) – must include trace_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback.{run_id}name")]
        public string? Feedback_runId_name { get; set; }

        /// <summary>
        /// Binary attachment linked to run {run_id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment.{run_id}.{filename}")]
        public byte[]? Attachment_runId__filename_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request3(
            byte[]? post_runId_,
            string? post_runId_name,
            byte[]? patch_runId_,
            string? patch_runId_name,
            byte[]? post_runId_Inputs,
            string? post_runId_Inputsname,
            byte[]? patch_runId_Outputs,
            string? patch_runId_Outputsname,
            byte[]? feedback_runId_,
            string? feedback_runId_name,
            byte[]? attachment_runId__filename_)
        {
            this.Post_runId_ = post_runId_;
            this.Post_runId_name = post_runId_name;
            this.Patch_runId_ = patch_runId_;
            this.Patch_runId_name = patch_runId_name;
            this.Post_runId_Inputs = post_runId_Inputs;
            this.Post_runId_Inputsname = post_runId_Inputsname;
            this.Patch_runId_Outputs = patch_runId_Outputs;
            this.Patch_runId_Outputsname = patch_runId_Outputsname;
            this.Feedback_runId_ = feedback_runId_;
            this.Feedback_runId_name = feedback_runId_name;
            this.Attachment_runId__filename_ = attachment_runId__filename_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        public Request3()
        {
        }
    }
}