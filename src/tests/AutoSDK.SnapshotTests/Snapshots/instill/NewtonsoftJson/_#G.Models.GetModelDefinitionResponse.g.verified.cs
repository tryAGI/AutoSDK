//HintName: G.Models.GetModelDefinitionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetModelDefinitionResponse contains the requested model definition.
    /// </summary>
    public sealed partial class GetModelDefinitionResponse
    {
        /// <summary>
        /// The model definition resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelDefinition")]
        public global::G.ModelDefinition? ModelDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelDefinitionResponse" /> class.
        /// </summary>
        /// <param name="modelDefinition">
        /// The model definition resource.<br/>
        /// Included only in responses
        /// </param>
        public GetModelDefinitionResponse(
            global::G.ModelDefinition? modelDefinition)
        {
            this.ModelDefinition = modelDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelDefinitionResponse" /> class.
        /// </summary>
        public GetModelDefinitionResponse()
        {
        }
    }
}