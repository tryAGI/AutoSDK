//HintName: G.Models.GetConnectedAccountsResponseItemDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetConnectedAccountsResponseItemDeprecated
    {
        /// <summary>
        /// The labels of the connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// The uuid of the connection
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
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemDeprecated" /> class.
        /// </summary>
        /// <param name="labels">
        /// The labels of the connection
        /// </param>
        /// <param name="uuid">
        /// The uuid of the connection
        /// </param>
        public GetConnectedAccountsResponseItemDeprecated(
            global::System.Collections.Generic.IList<string> labels,
            global::System.Guid uuid)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemDeprecated" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemDeprecated()
        {
        }
    }
}