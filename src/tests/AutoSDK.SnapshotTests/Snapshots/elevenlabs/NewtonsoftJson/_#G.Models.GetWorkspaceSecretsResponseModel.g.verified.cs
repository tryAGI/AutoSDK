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
        [global::Newtonsoft.Json.JsonProperty("secrets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConvAIWorkspaceStoredSecretConfig> Secrets { get; set; } = default!;

        /// <summary>
        /// Cursor for fetching the next page of secrets
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more secrets to fetch<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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