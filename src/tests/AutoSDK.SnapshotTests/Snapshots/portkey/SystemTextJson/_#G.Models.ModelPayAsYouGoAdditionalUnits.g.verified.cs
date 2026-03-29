//HintName: G.Models.ModelPayAsYouGoAdditionalUnits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provider-specific additional pricing units.<br/>
    /// Common additional units:<br/>
    /// - `web_search`: Web search tool usage<br/>
    /// - `file_search`: File search tool usage<br/>
    /// - `thinking_token`: Chain-of-thought reasoning tokens (Google)<br/>
    /// - `image_token`: Image generation tokens<br/>
    /// - `video_duration_seconds_*`: Video generation (OpenAI Sora)
    /// </summary>
    public sealed partial class ModelPayAsYouGoAdditionalUnits
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}