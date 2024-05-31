//HintName: G.Models.PushModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for pushing a model.
    /// </summary>
    public sealed partial class PushModelRequest
    {
        /// <summary>
        /// The name of the model to push in the form of &lt;namespace&gt;/&lt;model&gt;:&lt;tag&gt;.
        /// <br/>Example: mattw/pygmalion:latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Allow insecure connections to the library. 
        /// Only use this if you are pushing to your library during development.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insecure")]
        public bool Insecure { get; set; } = false;

        /// <summary>
        /// Ollama username.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Ollama password.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

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