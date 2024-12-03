//HintName: G.Models.ModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response class for the list models endpoint.
    /// </summary>
    public sealed partial class ModelsResponse
    {
        /// <summary>
        /// List of models available locally.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::System.Collections.Generic.IList<global::G.Model>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models available locally.
        /// </param>
        public ModelsResponse(
            global::System.Collections.Generic.IList<global::G.Model>? models)
        {
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse" /> class.
        /// </summary>
        public ModelsResponse()
        {
        }
    }
}