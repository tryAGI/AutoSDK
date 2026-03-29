//HintName: G.Models.LanguageIdentificationResultItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageIdentificationResultItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternatives")]
        public global::System.Collections.Generic.IList<global::G.LanguageIdentificationResultAlternative>? Alternatives { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public double? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResultItem" /> class.
        /// </summary>
        /// <param name="alternatives"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageIdentificationResultItem(
            global::System.Collections.Generic.IList<global::G.LanguageIdentificationResultAlternative>? alternatives,
            double? startTime,
            double? endTime)
        {
            this.Alternatives = alternatives;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationResultItem" /> class.
        /// </summary>
        public LanguageIdentificationResultItem()
        {
        }
    }
}