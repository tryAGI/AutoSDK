//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant1Credentials.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: {}
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant1Credentials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_scopes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? UserScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant1Credentials" /> class.
        /// </summary>
        /// <param name="scopes"></param>
        /// <param name="userScopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsRequestAuthConfigVariant1Credentials(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? scopes,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? userScopes)
        {
            this.Scopes = scopes;
            this.UserScopes = userScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant1Credentials" /> class.
        /// </summary>
        public PostAuthConfigsRequestAuthConfigVariant1Credentials()
        {
        }
    }
}