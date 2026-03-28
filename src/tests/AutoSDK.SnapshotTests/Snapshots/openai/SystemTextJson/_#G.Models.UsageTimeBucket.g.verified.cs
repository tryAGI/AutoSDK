//HintName: G.Models.UsageTimeBucket.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageTimeBucketObjectJsonConverter))]
        public global::G.UsageTimeBucketObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.UsageCompletionsResult, global::G.UsageEmbeddingsResult, global::G.UsageModerationsResult, global::G.UsageImagesResult, global::G.UsageAudioSpeechesResult, global::G.UsageAudioTranscriptionsResult, global::G.UsageVectorStoresResult, global::G.UsageCodeInterpreterSessionsResult, global::G.CostsResult>> Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="result"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageTimeBucket(
            int startTime,
            int endTime,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UsageCompletionsResult, global::G.UsageEmbeddingsResult, global::G.UsageModerationsResult, global::G.UsageImagesResult, global::G.UsageAudioSpeechesResult, global::G.UsageAudioTranscriptionsResult, global::G.UsageVectorStoresResult, global::G.UsageCodeInterpreterSessionsResult, global::G.CostsResult>> result,
            global::G.UsageTimeBucketObject @object)
        {
            this.Object = @object;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTimeBucket" /> class.
        /// </summary>
        public UsageTimeBucket()
        {
        }
    }
}