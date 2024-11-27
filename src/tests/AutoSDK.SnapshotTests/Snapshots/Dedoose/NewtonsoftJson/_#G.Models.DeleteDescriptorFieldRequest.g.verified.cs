//HintName: G.Models.DeleteDescriptorFieldRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDescriptorFieldRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DescriptorField Field { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorFieldRequest" /> class.
        /// </summary>
        /// <param name="field"></param>
        public DeleteDescriptorFieldRequest(
            global::G.DescriptorField field)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorFieldRequest" /> class.
        /// </summary>
        public DeleteDescriptorFieldRequest()
        {
        }
    }
}