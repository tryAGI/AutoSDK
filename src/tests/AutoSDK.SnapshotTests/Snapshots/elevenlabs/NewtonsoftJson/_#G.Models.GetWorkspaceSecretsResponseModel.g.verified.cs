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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceSecretsResponseModel" /> class.
        /// </summary>
        /// <param name="secrets"></param>
        public GetWorkspaceSecretsResponseModel(
            global::System.Collections.Generic.IList<global::G.ConvAIWorkspaceStoredSecretConfig> secrets)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspaceSecretsResponseModel" /> class.
        /// </summary>
        public GetWorkspaceSecretsResponseModel()
        {
        }
    }
}