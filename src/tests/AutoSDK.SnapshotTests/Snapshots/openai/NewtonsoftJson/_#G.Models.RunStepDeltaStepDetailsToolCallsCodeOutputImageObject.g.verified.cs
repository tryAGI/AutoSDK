//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? Image { get; set; }

        /// <summary>
        /// The index of the output in the outputs array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="index">
        /// The index of the output in the outputs array.
        /// </param>
        /// <param name="type">
        /// Always `image`.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject(
            int index,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectImage? image,
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObjectType type)
        {
            this.Index = index;
            this.Image = image;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsCodeOutputImageObject()
        {
        }
    }
}