//HintName: G.Models.ResearchCreateRequestDtoClass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchCreateRequestDtoClass
    {
        /// <summary>
        /// Default Value: exa-research
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ResearchCreateRequestDtoClassModel? Model { get; set; }

        /// <summary>
        /// Instructions for what research should be conducted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchCreateRequestDtoClass" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions for what research should be conducted
        /// </param>
        /// <param name="model">
        /// Default Value: exa-research
        /// </param>
        /// <param name="outputSchema"></param>
        public ResearchCreateRequestDtoClass(
            string instructions,
            global::G.ResearchCreateRequestDtoClassModel? model,
            object? outputSchema)
        {
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchCreateRequestDtoClass" /> class.
        /// </summary>
        public ResearchCreateRequestDtoClass()
        {
        }
    }
}