//HintName: G.Models.UpdateProjectRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestBody" /> class.
        /// </summary>
        /// <param name="description"></param>
        public UpdateProjectRequestBody(
            string? description)
        {
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestBody" /> class.
        /// </summary>
        public UpdateProjectRequestBody()
        {
        }
    }
}