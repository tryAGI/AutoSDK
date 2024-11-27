//HintName: G.Models.DeleteDescriptorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDescriptorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Descriptor Descriptor { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorRequest" /> class.
        /// </summary>
        /// <param name="descriptor"></param>
        public DeleteDescriptorRequest(
            global::G.Descriptor descriptor)
        {
            this.Descriptor = descriptor ?? throw new global::System.ArgumentNullException(nameof(descriptor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorRequest" /> class.
        /// </summary>
        public DeleteDescriptorRequest()
        {
        }
    }
}