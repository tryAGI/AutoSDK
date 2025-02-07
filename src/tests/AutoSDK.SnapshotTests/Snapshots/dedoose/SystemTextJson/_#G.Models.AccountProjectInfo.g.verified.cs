//HintName: G.Models.AccountProjectInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountProjectInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectTitle")]
        public string? ProjectTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioHours")]
        public double? AudioHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoHours")]
        public double? VideoHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyDataCost")]
        public double? MonthlyDataCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminId")]
        public global::System.Guid? AdminId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminUsername")]
        public string? AdminUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminEmail")]
        public string? AdminEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProjectInfo" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectTitle"></param>
        /// <param name="audioHours"></param>
        /// <param name="videoHours"></param>
        /// <param name="monthlyDataCost"></param>
        /// <param name="adminId"></param>
        /// <param name="adminUsername"></param>
        /// <param name="adminEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountProjectInfo(
            global::System.Guid? projectId,
            string? projectTitle,
            double? audioHours,
            double? videoHours,
            double? monthlyDataCost,
            global::System.Guid? adminId,
            string? adminUsername,
            string? adminEmail)
        {
            this.ProjectId = projectId;
            this.ProjectTitle = projectTitle;
            this.AudioHours = audioHours;
            this.VideoHours = videoHours;
            this.MonthlyDataCost = monthlyDataCost;
            this.AdminId = adminId;
            this.AdminUsername = adminUsername;
            this.AdminEmail = adminEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProjectInfo" /> class.
        /// </summary>
        public AccountProjectInfo()
        {
        }
    }
}