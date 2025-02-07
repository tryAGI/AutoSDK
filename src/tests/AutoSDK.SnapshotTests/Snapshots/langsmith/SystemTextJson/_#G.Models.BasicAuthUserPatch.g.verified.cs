//HintName: G.Models.BasicAuthUserPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicAuthUserPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthUserPatch" /> class.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicAuthUserPatch(
            string? password,
            string? fullName)
        {
            this.Password = password;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthUserPatch" /> class.
        /// </summary>
        public BasicAuthUserPatch()
        {
        }
    }
}