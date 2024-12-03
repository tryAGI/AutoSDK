//HintName: G.Models.CreateModerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents if a given text input is potentially harmful.
    /// </summary>
    public sealed partial class CreateModerationResponse
    {
        /// <summary>
        /// The unique identifier for the moderation request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The model used to generate the moderation results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// A list of moderation objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateModerationResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the moderation request.
        /// </param>
        /// <param name="model">
        /// The model used to generate the moderation results.
        /// </param>
        /// <param name="results">
        /// A list of moderation objects.
        /// </param>
        public CreateModerationResponse(
            string id,
            string model,
            global::System.Collections.Generic.IList<global::G.CreateModerationResponseResult> results)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponse" /> class.
        /// </summary>
        public CreateModerationResponse()
        {
        }
    }
}