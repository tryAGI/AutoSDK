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
        [global::System.Text.Json.Serialization.JsonPropertyName("hasUsers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UserMetricsResult> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUsersUserMetricsResultArrayCountNumberHasUsersBooleanData" /> class.
        /// </summary>
        /// <param name="hasUsers"></param>
        /// <param name="count"></param>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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