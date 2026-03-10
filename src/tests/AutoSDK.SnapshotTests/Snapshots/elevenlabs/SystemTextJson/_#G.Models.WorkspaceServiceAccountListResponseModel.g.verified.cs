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
        [global::System.Text.Json.Serialization.JsonPropertyName("service-accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WorkspaceServiceAccountResponseModel> ServiceAccounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceServiceAccountListResponseModel" /> class.
        /// </summary>
        /// <param name="serviceAccounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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