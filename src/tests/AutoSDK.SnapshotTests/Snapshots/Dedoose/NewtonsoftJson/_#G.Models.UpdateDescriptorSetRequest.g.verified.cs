//HintName: G.Models.UpdateDescriptorSetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDescriptorSetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("set", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DescriptorSet Set { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDescriptorSetRequest" /> class.
        /// </summary>
        /// <param name="set"></param>
        public UpdateDescriptorSetRequest(
            global::G.DescriptorSet set)
        {
            this.Set = set ?? throw new global::System.ArgumentNullException(nameof(set));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDescriptorSetRequest" /> class.
        /// </summary>
        public UpdateDescriptorSetRequest()
        {
        }
    }
}