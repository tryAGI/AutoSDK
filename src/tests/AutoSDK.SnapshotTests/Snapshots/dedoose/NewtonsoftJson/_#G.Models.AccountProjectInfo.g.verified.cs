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
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectTitle")]
        public string? ProjectTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioHours")]
        public double? AudioHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videoHours")]
        public double? VideoHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthlyDataCost")]
        public double? MonthlyDataCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adminId")]
        public global::System.Guid? AdminId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adminUsername")]
        public string? AdminUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adminEmail")]
        public string? AdminEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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