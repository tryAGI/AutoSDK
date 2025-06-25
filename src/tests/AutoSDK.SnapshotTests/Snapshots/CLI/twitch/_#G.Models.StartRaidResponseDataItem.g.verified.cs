//HintName: G.Models.StartRaidResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartRaidResponseDataItem
    {
        /// <summary>
        /// The UTC date and time, in RFC3339 format, of when the raid was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the channel being raided contains mature content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartRaidResponseDataItem" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UTC date and time, in RFC3339 format, of when the raid was requested.
        /// </param>
        /// <param name="isMature">
        /// A Boolean value that indicates whether the channel being raided contains mature content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartRaidResponseDataItem(
            global::System.DateTime createdAt,
            bool isMature)
        {
            this.CreatedAt = createdAt;
            this.IsMature = isMature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartRaidResponseDataItem" /> class.
        /// </summary>
        public StartRaidResponseDataItem()
        {
        }
    }
}