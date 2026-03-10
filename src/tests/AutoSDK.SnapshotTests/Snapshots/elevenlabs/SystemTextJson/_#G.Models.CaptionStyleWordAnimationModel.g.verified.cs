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
        [global::System.Text.Json.Serialization.JsonPropertyName("enter_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CaptionStyleWordAnimationModelEnterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CaptionStyleWordAnimationModelEnterType EnterType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CaptionStyleWordAnimationModelExitTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CaptionStyleWordAnimationModelExitType ExitType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleWordAnimationModel" /> class.
        /// </summary>
        /// <param name="enterType"></param>
        /// <param name="exitType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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