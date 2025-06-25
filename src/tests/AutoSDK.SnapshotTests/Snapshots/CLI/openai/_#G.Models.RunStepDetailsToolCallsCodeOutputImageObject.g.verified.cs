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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStepDetailsToolCallsCodeOutputImageObjectTypeJsonConverter))]
        public global::G.RunStepDetailsToolCallsCodeOutputImageObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunStepDetailsToolCallsCodeOutputImageObjectImage Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsCodeOutputImageObject" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `image`.
        /// </param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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