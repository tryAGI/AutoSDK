//HintName: G.Models.AllowedLoginMethodsUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllowedLoginMethodsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SsoOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedLoginMethodsUpdate" /> class.
        /// </summary>
        /// <param name="ssoOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowedLoginMethodsUpdate(
            bool ssoOnly)
        {
            this.SsoOnly = ssoOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedLoginMethodsUpdate" /> class.
        /// </summary>
        public AllowedLoginMethodsUpdate()
        {
        }
    }
}