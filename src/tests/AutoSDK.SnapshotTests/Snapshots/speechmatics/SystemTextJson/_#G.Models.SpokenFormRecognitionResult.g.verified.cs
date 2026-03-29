//HintName: G.Models.SpokenFormRecognitionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A SpokenFormRecognitionResult describes a simple object which consists solely of 'word' or 'punctuation' type entries with a start and end time. It can occur only inside the spoken_form property of a full "RecognitionResult"
    /// </summary>
    public sealed partial class SpokenFormRecognitionResult
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpokenFormRecognitionResultTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpokenFormRecognitionResultType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenFormRecognitionResult" /> class.
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
        public SpokenFormRecognitionResult(
            global::System.Collections.Generic.IList<global::G.RecognitionAlternative> alternatives,
            float endTime,
            float startTime,
            global::G.SpokenFormRecognitionResultType type)
        {
            this.Alternatives = alternatives ?? throw new global::System.ArgumentNullException(nameof(alternatives));
            this.EndTime = endTime;
            this.StartTime = startTime;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpokenFormRecognitionResult" /> class.
        /// </summary>
        public SpokenFormRecognitionResult()
        {
        }
    }
}