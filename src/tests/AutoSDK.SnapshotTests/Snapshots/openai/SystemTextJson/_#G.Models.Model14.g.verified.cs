//HintName: G.Models.Model14.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describes an OpenAI model offering that can be used with the API.
    /// </summary>
    public sealed partial class Model14
    {
        /// <summary>
        /// The Unix timestamp (in seconds) when the model was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// The model identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always "model".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelObjectJsonConverter))]
        public global::G.ModelObject Object { get; set; }

        /// <summary>
        /// The organization that owns the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model14" /> class.
        /// </summary>
        /// <param name="created">
        /// The Unix timestamp (in seconds) when the model was created.
        /// </param>
        /// <param name="id">
        /// The model identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "model".
        /// </param>
        /// <param name="ownedBy">
        /// The organization that owns the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model14(
            global::System.DateTimeOffset created,
            string id,
            string ownedBy,
            global::G.ModelObject @object)
        {
            this.Created = created;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model14" /> class.
        /// </summary>
        public Model14()
        {
        }
    }
}