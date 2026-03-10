//HintName: G.Models.GetWorkspaceSecretsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkspaceSecretsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConvAIWorkspaceStoredSecretConfig> Secrets { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of secrets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more secrets to fetch<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceSecretsResponseModel" /> class.
        /// </summary>
        /// <param name="secrets"></param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of secrets
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more secrets to fetch<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkspaceSecretsResponseModel(
            global::System.Collections.Generic.IList<global::G.ConvAIWorkspaceStoredSecretConfig> secrets,
            string? nextCursor,
            bool? hasMore)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceSecretsResponseModel" /> class.
        /// </summary>
        public GetWorkspaceSecretsResponseModel()
        {
        }
    }
}