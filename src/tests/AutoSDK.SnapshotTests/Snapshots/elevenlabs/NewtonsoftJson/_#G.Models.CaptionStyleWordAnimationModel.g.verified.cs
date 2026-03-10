//HintName: G.Models.CaptionStyleWordAnimationModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleWordAnimationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enter_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CaptionStyleWordAnimationModelEnterType EnterType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exit_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CaptionStyleWordAnimationModelExitType ExitType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleWordAnimationModel" /> class.
        /// </summary>
        /// <param name="enterType"></param>
        /// <param name="exitType"></param>
        public CaptionStyleWordAnimationModel(
            global::G.CaptionStyleWordAnimationModelEnterType enterType,
            global::G.CaptionStyleWordAnimationModelExitType exitType)
        {
            this.EnterType = enterType;
            this.ExitType = exitType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleWordAnimationModel" /> class.
        /// </summary>
        public CaptionStyleWordAnimationModel()
        {
        }
    }
}