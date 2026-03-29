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
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.KPIUserInfo> Users { get; set; }

        /// <summary>
        /// Array of KPI values, one per user (parallel to users array)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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