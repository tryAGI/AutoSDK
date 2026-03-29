//HintName: G.Models.RecognitionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An ASR job output item. The primary item types are `word` and `punctuation`. Other item types may be present, for example to provide semantic information of different forms.<br/>
    /// Example: [{"channel":"channel_1","start_time":0.55,"end_time":1.2,"type":"word","volume":0.5,"alternatives":[{"confidence":0.95,"content":"Hello","language":"en","speaker":"S1","display":{"direction":"ltr"}}]}]
    /// </summary>
    public sealed partial class RecognitionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public float StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public float EndTime { get; set; } = default!;

        /// <summary>
        /// An indication of the volume of audio across the time period the word was spoken.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume")]
        public float? Volume { get; set; }

        /// <summary>
        /// Whether the punctuation mark is an end of sentence character. Only applies to punctuation marks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_eos")]
        public bool? IsEos { get; set; }

        /// <summary>
        /// New types of items may appear without being requested; unrecognized item types can be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecognitionResultType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("written_form")]
        public global::System.Collections.Generic.IList<global::G.WrittenFormRecognitionResult>? WrittenForm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spoken_form")]
        public global::System.Collections.Generic.IList<global::G.SpokenFormRecognitionResult>? SpokenForm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alternatives")]
        public global::System.Collections.Generic.IList<global::G.RecognitionAlternative>? Alternatives { get; set; }

        /// <summary>
        /// Attachment direction of the punctuation mark. This only applies to punctuation marks. This information can be used to produce a well-formed text representation by placing the `word_delimiter` from `language_pack_info` on the correct side of the punctuation mark.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attaches_to")]
        public global::G.RecognitionResultAttachesTo? AttachesTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionResult" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="type">
        /// New types of items may appear without being requested; unrecognized item types can be ignored.
        /// </param>
        /// <param name="channel"></param>
        /// <param name="volume">
        /// An indication of the volume of audio across the time period the word was spoken.
        /// </param>
        /// <param name="isEos">
        /// Whether the punctuation mark is an end of sentence character. Only applies to punctuation marks.
        /// </param>
        /// <param name="writtenForm"></param>
        /// <param name="spokenForm"></param>
        /// <param name="alternatives"></param>
        /// <param name="attachesTo">
        /// Attachment direction of the punctuation mark. This only applies to punctuation marks. This information can be used to produce a well-formed text representation by placing the `word_delimiter` from `language_pack_info` on the correct side of the punctuation mark.
        /// </param>
        public RecognitionResult(
            float startTime,
            float endTime,
            global::G.RecognitionResultType type,
            string? channel,
            float? volume,
            bool? isEos,
            global::System.Collections.Generic.IList<global::G.WrittenFormRecognitionResult>? writtenForm,
            global::System.Collections.Generic.IList<global::G.SpokenFormRecognitionResult>? spokenForm,
            global::System.Collections.Generic.IList<global::G.RecognitionAlternative>? alternatives,
            global::G.RecognitionResultAttachesTo? attachesTo)
        {
            this.Channel = channel;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Volume = volume;
            this.IsEos = isEos;
            this.Type = type;
            this.WrittenForm = writtenForm;
            this.SpokenForm = spokenForm;
            this.Alternatives = alternatives;
            this.AttachesTo = attachesTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionResult" /> class.
        /// </summary>
        public RecognitionResult()
        {
        }
    }
}