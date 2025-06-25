//HintName: G.Models.UltravoxV1StaticToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A predefined, static response for a tool. When a tool has a static response, it<br/>
    ///  can be returned immediately, without waiting for full tool execution.
    /// </summary>
    public sealed partial class UltravoxV1StaticToolResponse
    {
        /// <summary>
        /// The predefined text response to be returned immediately
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseText")]
        public string? ResponseText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StaticToolResponse" /> class.
        /// </summary>
        /// <param name="responseText">
        /// The predefined text response to be returned immediately
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1StaticToolResponse(
            string? responseText)
        {
            this.ResponseText = responseText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StaticToolResponse" /> class.
        /// </summary>
        public UltravoxV1StaticToolResponse()
        {
        }
    }
}