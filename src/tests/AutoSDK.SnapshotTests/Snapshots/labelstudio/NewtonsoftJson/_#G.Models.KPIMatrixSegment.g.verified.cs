//HintName: G.Models.KPIMatrixSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for 2D matrix segmentation (time × user) in compact format.<br/>
    /// Returns a 2D array where values[user_index][time_index] corresponds to<br/>
    /// users[user_index] at interval_start[time_index].
    /// </summary>
    public sealed partial class KPIMatrixSegment
    {
        /// <summary>
        /// Array of time period start timestamps
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.DateTime> IntervalStart { get; set; } = default!;

        /// <summary>
        /// Array of user information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.KPIUserInfo> Users { get; set; } = default!;

        /// <summary>
        /// 2D array of values: values[user_index][time_index]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIMatrixSegment" /> class.
        /// </summary>
        /// <param name="intervalStart">
        /// Array of time period start timestamps
        /// </param>
        /// <param name="users">
        /// Array of user information
        /// </param>
        /// <param name="values">
        /// 2D array of values: values[user_index][time_index]
        /// </param>
        public KPIMatrixSegment(
            global::System.Collections.Generic.IList<global::System.DateTime> intervalStart,
            global::System.Collections.Generic.IList<global::G.KPIUserInfo> users,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> values)
        {
            this.IntervalStart = intervalStart ?? throw new global::System.ArgumentNullException(nameof(intervalStart));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIMatrixSegment" /> class.
        /// </summary>
        public KPIMatrixSegment()
        {
        }
    }
}