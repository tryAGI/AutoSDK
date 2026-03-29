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
        [global::Newtonsoft.Json.JsonProperty("alternatives", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RecognitionAlternative> Alternatives { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public float EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public float StartTime { get; set; } = default!;

        /// <summary>
        /// What kind of object this is. See #/Definitions/RecognitionResult for definitions of the enums.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpokenFormRecognitionResultType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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