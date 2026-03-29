//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionJsonConverter))]
        public global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DataItem2> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy(
            global::System.Collections.Generic.IList<global::G.DataItem2> data,
            global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion version)
        {
            this.Version = version;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy" /> class.
        /// </summary>
        public ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy()
        {
        }
    }
}