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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsDuplicateCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the duplicated project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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