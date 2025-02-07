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
        [global::System.Text.Json.Serialization.JsonPropertyName("set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DescriptorSet Set { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDescriptorSetRequest" /> class.
        /// </summary>
        /// <param name="set"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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