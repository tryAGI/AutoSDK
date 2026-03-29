//HintName: G.Models.GetConnectedAccountsByNanoidResponseAuthConfigDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetConnectedAccountsByNanoidResponseAuthConfigDeprecated
    {
        /// <summary>
        /// The uuid of the auth config
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
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseAuthConfigDeprecated" /> class.
        /// </summary>
        /// <param name="uuid">
        /// The uuid of the auth config
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseAuthConfigDeprecated(
            global::System.Guid uuid)
        {
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseAuthConfigDeprecated" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseAuthConfigDeprecated()
        {
        }
    }
}