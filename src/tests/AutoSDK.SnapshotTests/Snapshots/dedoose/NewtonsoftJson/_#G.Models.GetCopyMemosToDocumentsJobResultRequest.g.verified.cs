﻿//HintName: G.Models.GetCopyMemosToDocumentsJobResultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCopyMemosToDocumentsJobResultRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobId", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCopyMemosToDocumentsJobResultRequest" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        public GetCopyMemosToDocumentsJobResultRequest(
            string jobId)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCopyMemosToDocumentsJobResultRequest" /> class.
        /// </summary>
        public GetCopyMemosToDocumentsJobResultRequest()
        {
        }
    }
}