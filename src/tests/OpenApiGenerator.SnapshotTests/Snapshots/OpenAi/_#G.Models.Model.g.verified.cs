//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes an OpenAI model offering that can be used with the API.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// The model identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) when the model was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public required int Created { get; set; }

        /// <summary>
        /// The object type, which is always "model".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public required Model._ObjectEnum Object { get; set; }

        /// <summary>
        /// The organization that owns the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public required string OwnedBy { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}