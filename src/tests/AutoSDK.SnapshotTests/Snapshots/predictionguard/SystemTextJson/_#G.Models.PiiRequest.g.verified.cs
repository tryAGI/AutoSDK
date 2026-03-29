//HintName: G.Models.PiiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PiiPostRequestBodyContentApplicationJsonSchemaPromptJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PiiPostRequestBodyContentApplicationJsonSchemaPrompt Prompt { get; set; }

        /// <summary>
        /// Whether to replace personal information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Replace { get; set; }

        /// <summary>
        /// The method to use (random, fake, category, mask).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_method")]
        public string? ReplaceMethod { get; set; }

        /// <summary>
        /// An array of entity types that the PII check should ignore.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_list")]
        public global::System.Collections.Generic.IList<string>? EntityList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="replace">
        /// Whether to replace personal information.
        /// </param>
        /// <param name="replaceMethod">
        /// The method to use (random, fake, category, mask).
        /// </param>
        /// <param name="entityList">
        /// An array of entity types that the PII check should ignore.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiRequest(
            global::G.PiiPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool replace,
            string? replaceMethod,
            global::System.Collections.Generic.IList<string>? entityList)
        {
            this.Prompt = prompt;
            this.Replace = replace;
            this.ReplaceMethod = replaceMethod;
            this.EntityList = entityList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiRequest" /> class.
        /// </summary>
        public PiiRequest()
        {
        }
    }
}