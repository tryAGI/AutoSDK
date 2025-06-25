//HintName: G.Models.AllowlistItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllowlistItem
    {
        /// <summary>
        /// The hostname of the allowed origin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        /// <param name="hostname">
        /// The hostname of the allowed origin
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowlistItem(
            string hostname)
        {
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        public AllowlistItem()
        {
        }
    }
}