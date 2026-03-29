//HintName: G.Models.PatchedHotkeysRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedHotkeysRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_hotkeys")]
        public object? CustomHotkeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedHotkeysRequest" /> class.
        /// </summary>
        /// <param name="customHotkeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedHotkeysRequest(
            object? customHotkeys)
        {
            this.CustomHotkeys = customHotkeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedHotkeysRequest" /> class.
        /// </summary>
        public PatchedHotkeysRequest()
        {
        }
    }
}