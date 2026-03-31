//HintName: G.Models.GetAnimationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnimationsResponseAnimation> Animations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponse" /> class.
        /// </summary>
        /// <param name="animations"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationsResponse(
            global::System.Collections.Generic.IList<global::G.GetAnimationsResponseAnimation> animations,
            string? token)
        {
            this.Animations = animations ?? throw new global::System.ArgumentNullException(nameof(animations));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponse" /> class.
        /// </summary>
        public GetAnimationsResponse()
        {
        }
    }
}