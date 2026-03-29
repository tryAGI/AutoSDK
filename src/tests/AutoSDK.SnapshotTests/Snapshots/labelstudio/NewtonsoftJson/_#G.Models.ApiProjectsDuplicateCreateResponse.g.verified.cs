//HintName: G.Models.ApiProjectsDuplicateCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsDuplicateCreateResponse
    {
        /// <summary>
        /// The ID of the duplicated project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsDuplicateCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the duplicated project.
        /// </param>
        public ApiProjectsDuplicateCreateResponse(
            int id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsDuplicateCreateResponse" /> class.
        /// </summary>
        public ApiProjectsDuplicateCreateResponse()
        {
        }
    }
}