//HintName: G.Models.LinkedToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkedToolResponse
    {
        /// <summary>
        /// Unique identifier for the linked tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the linked tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Version ID of the linked tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedToolResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the linked tool.
        /// </param>
        /// <param name="name">
        /// Name of the linked tool.
        /// </param>
        /// <param name="versionId">
        /// Version ID of the linked tool.
        /// </param>
        public LinkedToolResponse(
            string id,
            string? name,
            string? versionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedToolResponse" /> class.
        /// </summary>
        public LinkedToolResponse()
        {
        }
    }
}