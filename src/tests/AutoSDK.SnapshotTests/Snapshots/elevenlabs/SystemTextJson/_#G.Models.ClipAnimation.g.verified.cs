//HintName: G.Models.ClipAnimation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipAnimation
    {
        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enter_effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClipAnimationEnterEffectJsonConverter))]
        public global::G.ClipAnimationEnterEffect? EnterEffect { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enter_duration_ms")]
        public int? EnterDurationMs { get; set; }

        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_effect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClipAnimationExitEffectJsonConverter))]
        public global::G.ClipAnimationExitEffect? ExitEffect { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_duration_ms")]
        public int? ExitDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipAnimation" /> class.
        /// </summary>
        /// <param name="enterEffect">
        /// Default Value: none
        /// </param>
        /// <param name="enterDurationMs">
        /// Default Value: 0
        /// </param>
        /// <param name="exitEffect">
        /// Default Value: none
        /// </param>
        /// <param name="exitDurationMs">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipAnimation(
            global::G.ClipAnimationEnterEffect? enterEffect,
            int? enterDurationMs,
            global::G.ClipAnimationExitEffect? exitEffect,
            int? exitDurationMs)
        {
            this.EnterEffect = enterEffect;
            this.EnterDurationMs = enterDurationMs;
            this.ExitEffect = exitEffect;
            this.ExitDurationMs = exitDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipAnimation" /> class.
        /// </summary>
        public ClipAnimation()
        {
        }
    }
}