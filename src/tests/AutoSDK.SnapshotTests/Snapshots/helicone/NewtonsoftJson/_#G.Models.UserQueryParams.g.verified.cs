//HintName: G.Models.UserQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userIds")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter")]
        public global::G.UserQueryParamsTimeFilter? TimeFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserQueryParams" /> class.
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="timeFilter"></param>
        public UserQueryParams(
            global::System.Collections.Generic.IList<string>? userIds,
            global::G.UserQueryParamsTimeFilter? timeFilter)
        {
            this.UserIds = userIds;
            this.TimeFilter = timeFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserQueryParams" /> class.
        /// </summary>
        public UserQueryParams()
        {
        }
    }
}