//HintName: G.Models.GenerationsGetGenerationResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation response
    /// </summary>
    public sealed partial class GenerationsGetGenerationResponse200
    {
        /// <summary>
        /// Generation data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerationGetResponsesContentApplicationJsonSchemaData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsGetGenerationResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// Generation data
        /// </param>
        public GenerationsGetGenerationResponse200(
            global::G.GenerationGetResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsGetGenerationResponse200" /> class.
        /// </summary>
        public GenerationsGetGenerationResponse200()
        {
        }
    }
}