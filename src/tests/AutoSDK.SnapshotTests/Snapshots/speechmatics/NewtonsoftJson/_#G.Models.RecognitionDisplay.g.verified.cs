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
        [global::Newtonsoft.Json.JsonProperty("direction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecognitionDisplayDirection Direction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionDisplay" /> class.
        /// </summary>
        /// <param name="direction"></param>
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