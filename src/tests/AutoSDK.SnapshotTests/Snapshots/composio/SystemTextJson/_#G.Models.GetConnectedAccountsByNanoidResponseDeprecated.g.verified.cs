//HintName: G.Models.GetConnectedAccountsByNanoidResponseDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetConnectedAccountsByNanoidResponseDeprecated
    {
        /// <summary>
        /// The labels of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// The uuid of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseDeprecated" /> class.
        /// </summary>
        /// <param name="labels">
        /// The labels of the connection
        /// </param>
        /// <param name="uuid">
        /// The uuid of the connection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseDeprecated(
            global::System.Collections.Generic.IList<string> labels,
            global::System.Guid uuid)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseDeprecated" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseDeprecated()
        {
        }
    }
}