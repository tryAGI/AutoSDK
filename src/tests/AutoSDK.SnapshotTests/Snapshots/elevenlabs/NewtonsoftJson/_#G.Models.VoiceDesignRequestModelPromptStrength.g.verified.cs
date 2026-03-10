//HintName: G.Models.VoiceDesignRequestModelPromptStrength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the balance of prompt versus reference audio when generating voice samples. 0 means almost no prompt influence, 1 means almost no reference audio influence. Only supported when using the eleven_ttv_v3 model.
    /// </summary>
    public sealed partial class VoiceDesignRequestModelPromptStrength
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}