//HintName: G.Models.ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasUsers", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasUsers { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserMetricsResult> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData" /> class.
        /// </summary>
        /// <param name="hasUsers"></param>
        /// <param name="count"></param>
        /// <param name="users"></param>
        public ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData(
            bool hasUsers,
            double count,
            global::System.Collections.Generic.IList<global::G.UserMetricsResult> users)
        {
            this.HasUsers = hasUsers;
            this.Count = count;
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData" /> class.
        /// </summary>
        public ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData()
        {
        }
    }
}