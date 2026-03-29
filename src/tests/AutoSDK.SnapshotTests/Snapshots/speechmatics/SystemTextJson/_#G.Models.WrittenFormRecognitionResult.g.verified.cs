//HintName: G.Models.WrittenFormRecognitionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A WrittenFormRecognitionResult describes a simple object which consists solely of 'word' type entries with a start and end time. It can occur only inside the written_form property of a full RecognitionResult"
    /// </summary>
    public sealed partial class WrittenFormRecognitionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RecognitionAlternative> Alternatives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float StartTime { get; set; }

        /// <summary>
        /// What kind of object this is. See #/Definitions/RecognitionResult for definitions of the enums.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WrittenFormRecognitionResultTypeJsonConverter))]
        public global::G.WrittenFormRecognitionResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WrittenFormRecognitionResult" /> class.
        /// </summary>
        /// <param name="alternatives"></param>
        /// <param name="endTime"></param>
        /// <param name="startTime"></param>
        /// <param name="type">
        /// What kind of object this is. See #/Definitions/RecognitionResult for definitions of the enums.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WrittenFormRecognitionResult(
            global::System.Collections.Generic.IList<global::G.RecognitionAlternative> alternatives,
            float endTime,
            float startTime,
            global::G.WrittenFormRecognitionResultType type)
        {
            this.Alternatives = alternatives ?? throw new global::System.ArgumentNullException(nameof(alternatives));
            this.EndTime = endTime;
            this.StartTime = startTime;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrittenFormRecognitionResult" /> class.
        /// </summary>
        public WrittenFormRecognitionResult()
        {
        }
    }
}