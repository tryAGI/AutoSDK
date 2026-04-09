//HintName: G.Models.CaptionStyleSectionAnimationModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleSectionAnimationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enter_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CaptionStyleSectionAnimationModelEnterTypeJsonConverter))]
        public global::G.CaptionStyleSectionAnimationModelEnterType EnterType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exit_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CaptionStyleSectionAnimationModelExitTypeJsonConverter))]
        public global::G.CaptionStyleSectionAnimationModelExitType ExitType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleSectionAnimationModel" /> class.
        /// </summary>
        /// <param name="enterType"></param>
        /// <param name="exitType"></param>
        public CaptionStyleSectionAnimationModel(
            global::G.CaptionStyleSectionAnimationModelEnterType enterType,
            global::G.CaptionStyleSectionAnimationModelExitType exitType)
        {
            this.EnterType = enterType;
            this.ExitType = exitType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleSectionAnimationModel" /> class.
        /// </summary>
        public CaptionStyleSectionAnimationModel()
        {
        }
    }
}