//HintName: G.Models.RetellLLMResponseVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetellLLMResponseVariant3
    {
        /// <summary>
        /// Last modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </summary>
        /// <example>1703413636133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modification_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long LastModificationTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLLMResponseVariant3" /> class.
        /// </summary>
        /// <param name="lastModificationTimestamp">
        /// Last modification timestamp (milliseconds since epoch). Either the time of last update or creation if no updates available.<br/>
        /// Example: 1703413636133
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetellLLMResponseVariant3(
            long lastModificationTimestamp)
        {
            this.LastModificationTimestamp = lastModificationTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLLMResponseVariant3" /> class.
        /// </summary>
        public RetellLLMResponseVariant3()
        {
        }
    }
}