//HintName: G.Models.SpeakersInputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakersInputItem
    {
        /// <summary>
        /// Speaker label, which must not match the format used internally (e.g. S1, S2, etc)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_identifiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SpeakerIdentifiers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakersInputItem" /> class.
        /// </summary>
        /// <param name="label">
        /// Speaker label, which must not match the format used internally (e.g. S1, S2, etc)
        /// </param>
        /// <param name="speakerIdentifiers"></param>
        public SpeakersInputItem(
            string label,
            global::System.Collections.Generic.IList<string> speakerIdentifiers)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.SpeakerIdentifiers = speakerIdentifiers ?? throw new global::System.ArgumentNullException(nameof(speakerIdentifiers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakersInputItem" /> class.
        /// </summary>
        public SpeakersInputItem()
        {
        }
    }
}