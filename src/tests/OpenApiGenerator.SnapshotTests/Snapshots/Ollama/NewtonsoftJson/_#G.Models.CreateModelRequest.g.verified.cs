//HintName: G.Models.CreateModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create model request object.
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: mario
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The contents of the Modelfile.
        /// <br/>Example: FROM llama2\nSYSTEM You are mario from Super Mario Bros.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelfile", Required = global::Newtonsoft.Json.Required.Always)]
        public string Modelfile { get; set; } = default!;

        /// <summary>
        /// Path to the Modelfile (optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The quantization level of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantize")]
        public string? Quantize { get; set; }

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.
        /// <br/>Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool Stream { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}