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
        /// The type of location approximation. Always `approximate`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateChatCompletionRequestVariant2WebSearchOptionsUserLocationType Type { get; set; }

        /// <summary>
        /// Approximate location parameters for the search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approximate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebSearchLocation Approximate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestVariant2WebSearchOptionsUserLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of location approximation. Always `approximate`.
        /// </param>
        /// <param name="approximate">
        /// Approximate location parameters for the search.
        /// </param>
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