//HintName: G.Models.CreateTextTo3DTaskRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextTo3DTaskRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.CreateTextTo3DTaskRequestDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextTo3DTaskRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
        public CreateTextTo3DTaskRequestDiscriminator(
            global::G.CreateTextTo3DTaskRequestDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextTo3DTaskRequestDiscriminator" /> class.
        /// </summary>
        public CreateTextTo3DTaskRequestDiscriminator()
        {
        }
    }
}