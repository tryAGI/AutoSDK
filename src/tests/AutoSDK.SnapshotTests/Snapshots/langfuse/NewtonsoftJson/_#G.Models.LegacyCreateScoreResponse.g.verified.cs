//HintName: G.Models.LegacyCreateScoreResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyCreateScoreResponse
    {
        /// <summary>
        /// The id of the created object in Langfuse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCreateScoreResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the created object in Langfuse
        /// </param>
        public LegacyCreateScoreResponse(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCreateScoreResponse" /> class.
        /// </summary>
        public LegacyCreateScoreResponse()
        {
        }
    }
}