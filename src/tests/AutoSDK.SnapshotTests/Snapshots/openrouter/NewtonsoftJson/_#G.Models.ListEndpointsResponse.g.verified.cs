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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Display name of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unix timestamp of when the model was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public double Created { get; set; } = default!;

        /// <summary>
        /// Description of the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("architecture", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListEndpointsResponseArchitecture Architecture { get; set; } = default!;

        /// <summary>
        /// List of available endpoints for this model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoints", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PublicEndpoint> Endpoints { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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