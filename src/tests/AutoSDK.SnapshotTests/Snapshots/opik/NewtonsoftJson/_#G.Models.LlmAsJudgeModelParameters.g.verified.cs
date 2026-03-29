//HintName: G.Models.LlmAsJudgeModelParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeModelParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature", Required = global::Newtonsoft.Json.Required.Always)]
        public double Temperature { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_parameters")]
        public global::G.JsonNode? CustomParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParameters" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temperature"></param>
        /// <param name="seed"></param>
        /// <param name="customParameters"></param>
        public LlmAsJudgeModelParameters(
            string name,
            double temperature,
            int? seed,
            global::G.JsonNode? customParameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Temperature = temperature;
            this.Seed = seed;
            this.CustomParameters = customParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParameters" /> class.
        /// </summary>
        public LlmAsJudgeModelParameters()
        {
        }
    }
}