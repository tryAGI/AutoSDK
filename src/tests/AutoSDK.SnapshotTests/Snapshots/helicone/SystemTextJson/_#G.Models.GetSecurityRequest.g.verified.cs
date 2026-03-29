//HintName: G.Models.GetSecurityRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSecurityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Advanced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityRequest" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="advanced"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecurityRequest(
            string text,
            bool advanced)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Advanced = advanced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecurityRequest" /> class.
        /// </summary>
        public GetSecurityRequest()
        {
        }
    }
}