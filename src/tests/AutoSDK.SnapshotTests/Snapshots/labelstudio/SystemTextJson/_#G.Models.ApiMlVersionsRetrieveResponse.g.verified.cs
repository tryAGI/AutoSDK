//HintName: G.Models.ApiMlVersionsRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMlVersionsRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<string>? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlVersionsRetrieveResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiMlVersionsRetrieveResponse(
            string? message,
            global::System.Collections.Generic.IList<string>? versions)
        {
            this.Message = message;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlVersionsRetrieveResponse" /> class.
        /// </summary>
        public ApiMlVersionsRetrieveResponse()
        {
        }
    }
}