//HintName: G.Models.ModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"models":[{"name":"Palmyra X 003 Instruct","id":"palmyra-x-003-instruct"},{"name":"Palmyra Med","id":"palmyra-med"},{"name":"Palmyra Financial","id":"palmyra-fin"},{"name":"Palmyra X4","id":"palmyra-x4"},{"name":"Palmyra X5","id":"palmyra-x5"},{"name":"Palmyra Creative","id":"palmyra-creative"}]}
    /// </summary>
    public sealed partial class ModelsResponse
    {
        /// <summary>
        /// The [ID of the model](https://dev.writer.com/home/models) to use for processing the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelInfo> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// The [ID of the model](https://dev.writer.com/home/models) to use for processing the request.
        /// </param>
        public ModelsResponse(
            global::System.Collections.Generic.IList<global::G.ModelInfo> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        public ModelsResponse()
        {
        }
    }
}