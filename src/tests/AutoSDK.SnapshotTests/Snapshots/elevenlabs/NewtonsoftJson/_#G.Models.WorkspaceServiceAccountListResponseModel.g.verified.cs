//HintName: G.Models.WorkspaceServiceAccountListResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceServiceAccountListResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service-accounts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkspaceServiceAccountResponseModel> ServiceAccounts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountListResponseModel" /> class.
        /// </summary>
        /// <param name="serviceAccounts"></param>
        public WorkspaceServiceAccountListResponseModel(
            global::System.Collections.Generic.IList<global::G.WorkspaceServiceAccountResponseModel> serviceAccounts)
        {
            this.ServiceAccounts = serviceAccounts ?? throw new global::System.ArgumentNullException(nameof(serviceAccounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountListResponseModel" /> class.
        /// </summary>
        public WorkspaceServiceAccountListResponseModel()
        {
        }
    }
}