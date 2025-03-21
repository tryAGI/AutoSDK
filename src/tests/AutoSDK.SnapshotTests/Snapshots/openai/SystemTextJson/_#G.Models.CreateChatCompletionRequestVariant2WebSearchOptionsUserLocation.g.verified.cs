//HintName: G.Models.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Approximate location parameters for the search.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation
    {
        /// <summary>
        /// Approximate location parameters for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approximate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebSearchLocation Approximate { get; set; }

        /// <summary>
        /// The type of location approximation. Always `approximate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationTypeJsonConverter))]
        public global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation" /> class.
        /// </summary>
        /// <param name="approximate">
        /// Approximate location parameters for the search.
        /// </param>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation(
            global::G.WebSearchLocation approximate,
            global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType type)
        {
            this.Approximate = approximate ?? throw new global::System.ArgumentNullException(nameof(approximate));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation" /> class.
        /// </summary>
        public CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation()
        {
        }
    }
}