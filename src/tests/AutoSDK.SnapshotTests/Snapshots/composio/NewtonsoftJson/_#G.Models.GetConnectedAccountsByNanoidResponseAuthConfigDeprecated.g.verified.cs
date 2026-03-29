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
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseAuthConfigDeprecated" /> class.
        /// </summary>
        /// <param name="uuid">
        /// The uuid of the auth config
        /// </param>
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