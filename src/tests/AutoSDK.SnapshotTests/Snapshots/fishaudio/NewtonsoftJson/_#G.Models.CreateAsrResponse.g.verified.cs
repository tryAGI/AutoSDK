//HintName: G.Models.CreateAsrResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAsrResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Duration of the audio in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ASRSegment> Segments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrResponse" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="duration">
        /// Duration of the audio in seconds
        /// </param>
        /// <param name="segments"></param>
        public CreateAsrResponse(
            string text,
            double duration,
            global::System.Collections.Generic.IList<global::G.ASRSegment> segments)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Duration = duration;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsrResponse" /> class.
        /// </summary>
        public CreateAsrResponse()
        {
        }
    }
}