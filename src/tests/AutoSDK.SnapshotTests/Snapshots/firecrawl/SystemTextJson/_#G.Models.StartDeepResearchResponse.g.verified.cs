//HintName: G.Models.StartDeepResearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartDeepResearchResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// ID of the research job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="id">
        /// ID of the research job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartDeepResearchResponse(
            bool? success,
            global::System.Guid? id)
        {
            this.Success = success;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchResponse" /> class.
        /// </summary>
        public StartDeepResearchResponse()
        {
        }
    }
}