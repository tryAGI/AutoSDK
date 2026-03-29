//HintName: G.Models.PostedLanguageModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedLanguageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostedLanguageModelModelProviderJsonConverter))]
        public global::G.PostedLanguageModelModelProvider? ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_resource")]
        public string? ModelResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedLanguageModel" /> class.
        /// </summary>
        /// <param name="modelProvider"></param>
        /// <param name="modelResource"></param>
        /// <param name="temperature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedLanguageModel(
            global::G.PostedLanguageModelModelProvider? modelProvider,
            string? modelResource,
            double? temperature)
        {
            this.ModelProvider = modelProvider;
            this.ModelResource = modelResource;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedLanguageModel" /> class.
        /// </summary>
        public PostedLanguageModel()
        {
        }
    }
}