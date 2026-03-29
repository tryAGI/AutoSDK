//HintName: G.Models.StudioLlmModelPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioLlmModelPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.JsonNodePublic? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioLlmModelPublic" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="parameters"></param>
        public StudioLlmModelPublic(
            string model,
            global::G.JsonNodePublic? parameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioLlmModelPublic" /> class.
        /// </summary>
        public StudioLlmModelPublic()
        {
        }
    }
}