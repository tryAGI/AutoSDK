//HintName: G.Models.CreateLabelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLabelResponse
    {
        /// <summary>
        /// ID of the created label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the created label
        /// </param>
        public CreateLabelResponse(
            global::System.Guid? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelResponse" /> class.
        /// </summary>
        public CreateLabelResponse()
        {
        }
    }
}