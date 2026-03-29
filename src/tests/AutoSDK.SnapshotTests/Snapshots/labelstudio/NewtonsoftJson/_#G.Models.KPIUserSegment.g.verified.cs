//HintName: G.Models.KPIUserSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for user-segmented KPI data (compact format).<br/>
    /// Returns parallel arrays: users and values.
    /// </summary>
    public sealed partial class KPIUserSegment
    {
        /// <summary>
        /// Array of user information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.KPIUserInfo> Users { get; set; } = default!;

        /// <summary>
        /// Array of KPI values, one per user (parallel to users array)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserSegment" /> class.
        /// </summary>
        /// <param name="users">
        /// Array of user information
        /// </param>
        /// <param name="values">
        /// Array of KPI values, one per user (parallel to users array)
        /// </param>
        public KPIUserSegment(
            global::System.Collections.Generic.IList<global::G.KPIUserInfo> users,
            global::System.Collections.Generic.IList<double> values)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserSegment" /> class.
        /// </summary>
        public KPIUserSegment()
        {
        }
    }
}