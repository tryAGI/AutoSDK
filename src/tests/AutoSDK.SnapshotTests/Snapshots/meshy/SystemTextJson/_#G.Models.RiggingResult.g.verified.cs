//HintName: G.Models.RiggingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RiggingResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rigged_character_fbx_url")]
        public string? RiggedCharacterFbxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rigged_character_glb_url")]
        public string? RiggedCharacterGlbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_animations")]
        public global::G.BasicAnimations? BasicAnimations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingResult" /> class.
        /// </summary>
        /// <param name="riggedCharacterFbxUrl"></param>
        /// <param name="riggedCharacterGlbUrl"></param>
        /// <param name="basicAnimations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RiggingResult(
            string? riggedCharacterFbxUrl,
            string? riggedCharacterGlbUrl,
            global::G.BasicAnimations? basicAnimations)
        {
            this.RiggedCharacterFbxUrl = riggedCharacterFbxUrl;
            this.RiggedCharacterGlbUrl = riggedCharacterGlbUrl;
            this.BasicAnimations = basicAnimations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiggingResult" /> class.
        /// </summary>
        public RiggingResult()
        {
        }
    }
}