//HintName: G.Models.DubbingTranscriptCharacter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTranscriptCharacter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_s")]
        public double? StartS { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_s")]
        public double? EndS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptCharacter" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startS">
        /// Default Value: 0F
        /// </param>
        /// <param name="endS">
        /// Default Value: 0F
        /// </param>
        public DubbingTranscriptCharacter(
            string? text,
            double? startS,
            double? endS)
        {
            this.Text = text;
            this.StartS = startS;
            this.EndS = endS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptCharacter" /> class.
        /// </summary>
        public DubbingTranscriptCharacter()
        {
        }
    }
}