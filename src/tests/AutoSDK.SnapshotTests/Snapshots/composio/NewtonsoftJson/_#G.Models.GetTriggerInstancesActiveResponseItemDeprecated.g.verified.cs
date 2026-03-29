//HintName: G.Models.GetTriggerInstancesActiveResponseItemDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated fields for the trigger instance
    /// </summary>
    public sealed partial class GetTriggerInstancesActiveResponseItemDeprecated
    {
        /// <summary>
        /// Deprecated created_at for the trigger instance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItemDeprecated" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Deprecated created_at for the trigger instance
        /// </param>
        public GetTriggerInstancesActiveResponseItemDeprecated(
            string createdAt)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggerInstancesActiveResponseItemDeprecated" /> class.
        /// </summary>
        public GetTriggerInstancesActiveResponseItemDeprecated()
        {
        }
    }
}