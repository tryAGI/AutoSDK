//HintName: G.Models.OAuthCreateAuthKeysCodeResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthCreateAuthKeysCodeResponse200
    {
        /// <summary>
        /// Auth code data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthKeysCodePostResponsesContentApplicationJsonSchemaData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthCreateAuthKeysCodeResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// Auth code data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthCreateAuthKeysCodeResponse200(
            global::G.AuthKeysCodePostResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthCreateAuthKeysCodeResponse200" /> class.
        /// </summary>
        public OAuthCreateAuthKeysCodeResponse200()
        {
        }
    }
}