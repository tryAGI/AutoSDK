//HintName: G.Models.ListEndpointsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of available endpoints for a model
    /// </summary>
    public sealed partial class ListEndpointsResponse
    {
        /// <summary>
        /// Unique identifier for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// Description of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListEndpointsResponseArchitecture Architecture { get; set; }

        /// <summary>
        /// List of available endpoints for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PublicEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the model
        /// </param>
        /// <param name="name">
        /// Display name of the model
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was created
        /// </param>
        /// <param name="description">
        /// Description of the model
        /// </param>
        /// <param name="architecture"></param>
        /// <param name="endpoints">
        /// List of available endpoints for this model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsResponse(
            string id,
            string name,
            double created,
            string description,
            global::G.ListEndpointsResponseArchitecture architecture,
            global::System.Collections.Generic.IList<global::G.PublicEndpoint> endpoints)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Architecture = architecture ?? throw new global::System.ArgumentNullException(nameof(architecture));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        public ListEndpointsResponse()
        {
        }
    }
}