//HintName: G.Models.UsageTimeBucket.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTimeBucket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UsageTimeBucketObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UsageCompletionsResult, global::G.UsageEmbeddingsResult, global::G.UsageModerationsResult, global::G.UsageImagesResult, global::G.UsageAudioSpeechesResult, global::G.UsageAudioTranscriptionsResult, global::G.UsageVectorStoresResult, global::G.UsageCodeInterpreterSessionsResult, global::G.CostsResult>> Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="result"></param>
        public UsageTimeBucket(
            int startTime,
            int endTime,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UsageCompletionsResult, global::G.UsageEmbeddingsResult, global::G.UsageModerationsResult, global::G.UsageImagesResult, global::G.UsageAudioSpeechesResult, global::G.UsageAudioTranscriptionsResult, global::G.UsageVectorStoresResult, global::G.UsageCodeInterpreterSessionsResult, global::G.CostsResult>> result,
            global::G.UsageTimeBucketObject @object)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        public UsageTimeBucket()
        {
        }
    }
}