//HintName: G.Models.EditImageGetBackgroundExpandPrompt2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetBackgroundExpandPrompt2
    {
        /// <summary>
        /// If `ai.auto`, a pre-processing step is applied to expand the prompt into a longer form.<br/>
        /// Example: original prompt `"on a beach"`, expanded prompt: `"An object rests on the sandy shore of a tranquil beach. The object, partially covered in sand, casts a soft shadow under the warm sunlight. Seashells and driftwood are scattered around, with gentle waves lapping at the shore in the background, creating a serene coastal scene."`<br/>
        /// (Note: `background.expandPrompt.mode` only affects `background.prompt`)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EditImageGetBackgroundExpandPromptModeJsonConverter))]
        public global::G.EditImageGetBackgroundExpandPromptMode Mode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetBackgroundExpandPrompt2" /> class.
        /// </summary>
        /// <param name="mode">
        /// If `ai.auto`, a pre-processing step is applied to expand the prompt into a longer form.<br/>
        /// Example: original prompt `"on a beach"`, expanded prompt: `"An object rests on the sandy shore of a tranquil beach. The object, partially covered in sand, casts a soft shadow under the warm sunlight. Seashells and driftwood are scattered around, with gentle waves lapping at the shore in the background, creating a serene coastal scene."`<br/>
        /// (Note: `background.expandPrompt.mode` only affects `background.prompt`)
        /// </param>
        public EditImageGetBackgroundExpandPrompt2(
            global::G.EditImageGetBackgroundExpandPromptMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetBackgroundExpandPrompt2" /> class.
        /// </summary>
        public EditImageGetBackgroundExpandPrompt2()
        {
        }
    }
}