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
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Descriptor Descriptor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDescriptorRequest" /> class.
        /// </summary>
        /// <param name="descriptor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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