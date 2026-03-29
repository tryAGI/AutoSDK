//HintName: G.Models.EntitiesDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntitiesDeleteResponse
    {
        /// <summary>
        /// Example: Entity deleted successfully!
        /// </summary>
        /// <example>Entity deleted successfully!</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesDeleteResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Entity deleted successfully!
        /// </param>
        public EntitiesDeleteResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesDeleteResponse" /> class.
        /// </summary>
        public EntitiesDeleteResponse()
        {
        }
    }
}