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
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.DateTime> IntervalStart { get; set; }

        /// <summary>
        /// Array of user information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KPIUserInfo> Users { get; set; }

        /// <summary>
        /// 2D array of values: values[user_index][time_index]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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