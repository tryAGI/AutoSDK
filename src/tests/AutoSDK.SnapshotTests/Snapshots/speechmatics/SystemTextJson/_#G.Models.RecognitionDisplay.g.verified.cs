//HintName: G.Models.RecognitionDisplay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecognitionDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RecognitionDisplayDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RecognitionDisplayDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionDisplay" /> class.
        /// </summary>
        /// <param name="direction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognitionDisplay(
            global::G.RecognitionDisplayDirection direction)
        {
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionDisplay" /> class.
        /// </summary>
        public RecognitionDisplay()
        {
        }
    }
}