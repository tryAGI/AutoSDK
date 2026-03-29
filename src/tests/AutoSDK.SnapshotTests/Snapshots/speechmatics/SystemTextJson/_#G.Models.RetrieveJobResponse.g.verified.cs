//HintName: G.Models.RetrieveJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"job":{"created_at":"2018-01-09 12:29:01.853047\u002B00:00","data_name":"recording.mp3","duration":244,"id":"a1b2c3d4e5","status":"transcribing","type":"transcription","transcription_config":{"language":"en","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Agent","Caller"]},"notification_config":[{"url":"https://collector.myorg.com/callback","contents":["transcript","data"],"auth_headers":["Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VySWQiOiJiMDhmODZhZi0zNWRhLTQ4ZjItOGZhYi1jZWYzOTA0NjYwYmQifQ.-xN_h82PHVTCMA9vdoHrcZxH-x5mb11y1537t3rGzcM"]}],"tracking":{"title":"ACME Q12018 Statement","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}}}}
    /// </summary>
    public sealed partial class RetrieveJobResponse
    {
        /// <summary>
        /// Document describing a job. JobConfig will be present in JobDetails returned for GET jobs/{id} request in SaaS and in Batch Appliance, but it will not be present in JobDetails returned as item in RetrieveJobsResponse in case of Batch Appliance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobDetails Job { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveJobResponse" /> class.
        /// </summary>
        /// <param name="job">
        /// Document describing a job. JobConfig will be present in JobDetails returned for GET jobs/{id} request in SaaS and in Batch Appliance, but it will not be present in JobDetails returned as item in RetrieveJobsResponse in case of Batch Appliance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveJobResponse(
            global::G.JobDetails job)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveJobResponse" /> class.
        /// </summary>
        public RetrieveJobResponse()
        {
        }
    }
}