//HintName: G.Models.LlmAsJudgeModelParametersWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeModelParametersWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_parameters")]
        public global::G.JsonNodeWrite? CustomParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParametersWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temperature"></param>
        /// <param name="seed"></param>
        /// <param name="customParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmAsJudgeModelParametersWrite(
            string name,
            double temperature,
            int? seed,
            global::G.JsonNodeWrite? customParameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Temperature = temperature;
            this.Seed = seed;
            this.CustomParameters = customParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParametersWrite" /> class.
        /// </summary>
        public LlmAsJudgeModelParametersWrite()
        {
        }
    }
}