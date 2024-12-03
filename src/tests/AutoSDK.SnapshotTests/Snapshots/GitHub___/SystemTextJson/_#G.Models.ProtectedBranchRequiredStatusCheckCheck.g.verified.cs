//HintName: G.Models.ProtectedBranchRequiredStatusCheckCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredStatusCheckCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? AppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredStatusCheckCheck" /> class.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="appId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProtectedBranchRequiredStatusCheckCheck(
            string context,
            int? appId)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.AppId = appId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredStatusCheckCheck" /> class.
        /// </summary>
        public ProtectedBranchRequiredStatusCheckCheck()
        {
        }
    }
}