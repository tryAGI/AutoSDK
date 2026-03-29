//HintName: G.Models.ResearchEventDtoClassVariant3Variant3Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3Variant3Output
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResearchEventDtoClassVariant3Variant3OutputOutputTypeJsonConverter))]
        public global::G.ResearchEventDtoClassVariant3Variant3OutputOutputType OutputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant3Output" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant3Variant3Output(
            string content,
            global::G.ResearchEventDtoClassVariant3Variant3OutputOutputType outputType)
        {
            this.OutputType = outputType;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3Variant3Output" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3Variant3Output()
        {
        }
    }
}