//HintName: G.Models.Transcription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate a transcription of the audio in the video. The transcription can be output as a file in SRT or VTT format.
    /// </summary>
    public sealed partial class Transcription
    {
        /// <summary>
        /// The output format of the transcription file. The following formats are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`srt` - SRT captions format&lt;/li&gt;<br/>
        ///   &lt;li&gt;`vtt` - VTT captions format&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: vtt
        /// </summary>
        /// <example>vtt</example>
        [global::Newtonsoft.Json.JsonProperty("format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranscriptionFormatJsonConverter))]
        public global::G.TranscriptionFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        /// <param name="format">
        /// The output format of the transcription file. The following formats are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`srt` - SRT captions format&lt;/li&gt;<br/>
        ///   &lt;li&gt;`vtt` - VTT captions format&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: vtt
        /// </param>
        public Transcription(
            global::G.TranscriptionFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        public Transcription()
        {
        }
    }
}