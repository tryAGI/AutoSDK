//HintName: G.Models.ScrapeOptionsActionExecuteJavaScript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeOptionsActionExecuteJavaScript
    {
        /// <summary>
        /// Execute JavaScript code on the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScrapeOptionsActionExecuteJavaScriptTypeJsonConverter))]
        public global::G.ScrapeOptionsActionExecuteJavaScriptType Type { get; set; }

        /// <summary>
        /// JavaScript code to execute<br/>
        /// Example: document.querySelector('.button').click();
        /// </summary>
        /// <example>document.querySelector('.button').click();</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionExecuteJavaScript" /> class.
        /// </summary>
        /// <param name="script">
        /// JavaScript code to execute<br/>
        /// Example: document.querySelector('.button').click();
        /// </param>
        /// <param name="type">
        /// Execute JavaScript code on the page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeOptionsActionExecuteJavaScript(
            string script,
            global::G.ScrapeOptionsActionExecuteJavaScriptType type)
        {
            this.Type = type;
            this.Script = script ?? throw new global::System.ArgumentNullException(nameof(script));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsActionExecuteJavaScript" /> class.
        /// </summary>
        public ScrapeOptionsActionExecuteJavaScript()
        {
        }
    }
}