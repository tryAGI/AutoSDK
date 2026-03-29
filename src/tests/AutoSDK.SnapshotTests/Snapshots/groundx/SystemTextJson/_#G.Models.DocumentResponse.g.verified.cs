//HintName: G.Models.DocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::G.DocumentDetail? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentResponse(
            global::G.DocumentDetail? document)
        {
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentResponse" /> class.
        /// </summary>
        public DocumentResponse()
        {
        }
    }
}