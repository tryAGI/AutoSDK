//HintName: G.Models.MaskingRequestBodyDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MaskingRequestBodyDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_source")]
        public global::G.MaskingRequestBodyDiscriminatorMaskSource? MaskSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRequestBodyDiscriminator" /> class.
        /// </summary>
        /// <param name="maskSource"></param>
        public MaskingRequestBodyDiscriminator(
            global::G.MaskingRequestBodyDiscriminatorMaskSource? maskSource)
        {
            this.MaskSource = maskSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRequestBodyDiscriminator" /> class.
        /// </summary>
        public MaskingRequestBodyDiscriminator()
        {
        }
    }
}