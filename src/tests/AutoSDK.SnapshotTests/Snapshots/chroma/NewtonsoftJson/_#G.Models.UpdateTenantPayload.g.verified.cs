//HintName: G.Models.UpdateTenantPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTenantPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTenantPayload" /> class.
        /// </summary>
        /// <param name="resourceName"></param>
        public UpdateTenantPayload(
            string resourceName)
        {
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTenantPayload" /> class.
        /// </summary>
        public UpdateTenantPayload()
        {
        }
    }
}