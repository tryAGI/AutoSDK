//HintName: G.Models.RunGroupRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by")]
        public global::G.RunGroupBy GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AnyOf<string, object>? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? EndTime { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}