//HintName: G.Models.Enhancements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enhancements that can be applied to a rendition. Currently only supports the Dolby audio enhancement.
    /// </summary>
    public sealed partial class Enhancements
    {
        /// <summary>
        /// An audio enhancement that can be applied to the audio content of a rendition.<br/>
        /// The following providers are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_dolbyenhancement"&gt;DolbyEnhancement&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.DolbyEnhancement? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Enhancements" /> class.
        /// </summary>
        /// <param name="audio">
        /// An audio enhancement that can be applied to the audio content of a rendition.<br/>
        /// The following providers are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_dolbyenhancement"&gt;DolbyEnhancement&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        public Enhancements(
            global::G.DolbyEnhancement? audio)
        {
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Enhancements" /> class.
        /// </summary>
        public Enhancements()
        {
        }
    }
}