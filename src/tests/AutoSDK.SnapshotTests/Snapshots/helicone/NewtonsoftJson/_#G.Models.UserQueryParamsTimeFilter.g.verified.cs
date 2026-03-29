//HintName: G.Models.UserQueryParamsTimeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserQueryParamsTimeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTimeUnixSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndTimeUnixSeconds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTimeUnixSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimeUnixSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserQueryParamsTimeFilter" /> class.
        /// </summary>
        /// <param name="endTimeUnixSeconds"></param>
        /// <param name="startTimeUnixSeconds"></param>
        public UserQueryParamsTimeFilter(
            double endTimeUnixSeconds,
            double startTimeUnixSeconds)
        {
            this.EndTimeUnixSeconds = endTimeUnixSeconds;
            this.StartTimeUnixSeconds = startTimeUnixSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserQueryParamsTimeFilter" /> class.
        /// </summary>
        public UserQueryParamsTimeFilter()
        {
        }
    }
}