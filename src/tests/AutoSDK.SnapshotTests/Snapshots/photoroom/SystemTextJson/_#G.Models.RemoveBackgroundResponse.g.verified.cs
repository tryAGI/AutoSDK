//HintName: G.Models.RemoveBackgroundResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveBackgroundResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64img")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Base64img { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundResponse" /> class.
        /// </summary>
        /// <param name="base64img"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveBackgroundResponse(
            string base64img)
        {
            this.Base64img = base64img ?? throw new global::System.ArgumentNullException(nameof(base64img));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveBackgroundResponse" /> class.
        /// </summary>
        public RemoveBackgroundResponse()
        {
        }
    }
}