//HintName: G.Models.ListVoiceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListVoiceData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_list")]
        public global::System.Collections.Generic.IList<global::G.OpenAPIVoiceData>? VoiceList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoiceData" /> class.
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="voiceList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVoiceData(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::G.OpenAPIVoiceData>? voiceList)
        {
            this.HasMore = hasMore;
            this.VoiceList = voiceList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVoiceData" /> class.
        /// </summary>
        public ListVoiceData()
        {
        }
    }
}