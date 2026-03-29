//HintName: G.Models.DirectoryUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for updating a directory.
    /// </summary>
    public sealed partial class DirectoryUpdateRequest
    {
        /// <summary>
        /// Updated name for the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description for the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Updated name for the directory.
        /// </param>
        /// <param name="description">
        /// Updated description for the directory.
        /// </param>
        public DirectoryUpdateRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryUpdateRequest" /> class.
        /// </summary>
        public DirectoryUpdateRequest()
        {
        }
    }
}