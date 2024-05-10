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
        /// The name of the model to push in the form of <namespace>/<model>:<tag>.
        /// <br/>Example: mattw/pygmalion:latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Allow insecure connections to the library. 
        /// Only use this if you are pushing to your library during development.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insecure")]
        public bool Insecure { get; set; } = false;

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.
        /// <br/>Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}