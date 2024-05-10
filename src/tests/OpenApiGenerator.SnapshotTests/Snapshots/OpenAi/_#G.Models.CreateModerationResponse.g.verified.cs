//HintName: G.Models.CreateModerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents policy compliance report by OpenAI's content moderation model against a given input.
    /// </summary>
    public sealed partial class CreateModerationResponse
    {
        /// <summary>
        /// The unique identifier for the moderation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public required string Id { get; set; }

        /// <summary>
        /// The model used to generate the moderation results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public required string Model { get; set; }

        /// <summary>
        /// A list of moderation objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public required global::System.Collections.Generic.IList<CreateModerationResponseResults> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}