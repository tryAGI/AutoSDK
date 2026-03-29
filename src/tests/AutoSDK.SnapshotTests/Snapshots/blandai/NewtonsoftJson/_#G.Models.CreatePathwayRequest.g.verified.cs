//HintName: G.Models.CreatePathwayRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePathwayRequest
    {
        /// <summary>
        /// Name of the conversational pathway
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the pathway
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePathwayRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the conversational pathway
        /// </param>
        /// <param name="description">
        /// Description of the pathway
        /// </param>
        public CreatePathwayRequest(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePathwayRequest" /> class.
        /// </summary>
        public CreatePathwayRequest()
        {
        }
    }
}