//HintName: G.Models.RunStepDetailsToolCallsCodeOutputImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsCodeOutputImageObject
    {
        /// <summary>
        /// Always `image`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RunStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `image`.
        /// </param>
        /// <param name="image"></param>
        public RunStepDetailsToolCallsCodeOutputImageObject(
            global::G.RunStepDetailsToolCallsCodeOutputImageObjectImage image,
            global::G.RunStepDetailsToolCallsCodeOutputImageObjectType type)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsCodeOutputImageObject()
        {
        }
    }
}