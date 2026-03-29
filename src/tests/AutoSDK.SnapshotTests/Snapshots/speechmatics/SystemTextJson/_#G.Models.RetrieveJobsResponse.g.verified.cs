//HintName: G.Models.RetrieveJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"jobs":[{"created_at":"2018-01-09 12:29:01.853047\u002B00:00","data_name":"recording.mp3","duration":244,"id":"a1b2c3d4e5","status":"transcribing","type":"transcription","tracking":{"title":"ACME Q12018 Statement","reference":"/data/clients/ACME/statements/segs/2018Q1-seg8","tags":["quick-review","segment"],"details":{"client":"ACME Corp","segment":8,"seg_start":963.201,"seg_end":1091.481}},"transcription_config":{"language":"en","additional_vocab":[{"content":"Speechmatics","sounds_like":["speechmatics"]},{"content":"gnocchi","sounds_like":["nyohki","nokey","nochi"]},{"content":"CEO","sounds_like":["C.E.O."]},{"content":"financial crisis"}],"diarization":"channel","channel_diarization_labels":["Agent","Caller"]},"notification_config":[{"url":"https://collector.example.org/callback","contents":["transcript","data"],"auth_headers":["Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VySWQiOiJiMDhmODZhZi0zNWRhLTQ4ZjItOGZhYi1jZWYzOTA0NjYwYmQifQ.-xN_h82PHVTCMA9vdoHrcZxH-x5mb11y1537t3rGzcM"]}]},{"created_at":"2018-01-09 11:23:42.984612\u002B00:00","data_name":"hello.wav","duration":130,"id":"084d1f86-9fe9-11e8-9c91-00155d019c0b","status":"aligning","type":"alignment","text_name":"hello.txt","alignment_config":{"language":"en"},"notification_config":[{"url":"https://collector.example.org/trigger-fetch","contents":[]}],"tracking":{"title":"Project X Intro","reference":"/data/projects/X/overview/audio/hello.wav"}}]}
    /// </summary>
    public sealed partial class RetrieveJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.JobDetails> Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveJobsResponse(
            global::System.Collections.Generic.IList<global::G.JobDetails> jobs)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveJobsResponse" /> class.
        /// </summary>
        public RetrieveJobsResponse()
        {
        }
    }
}