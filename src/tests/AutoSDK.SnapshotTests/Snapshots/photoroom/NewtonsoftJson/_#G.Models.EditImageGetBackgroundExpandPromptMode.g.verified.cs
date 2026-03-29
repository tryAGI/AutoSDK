//HintName: G.Models.EditImageGetBackgroundExpandPromptMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If `ai.auto`, a pre-processing step is applied to expand the prompt into a longer form.<br/>
    /// Example: original prompt `"on a beach"`, expanded prompt: `"An object rests on the sandy shore of a tranquil beach. The object, partially covered in sand, casts a soft shadow under the warm sunlight. Seashells and driftwood are scattered around, with gentle waves lapping at the shore in the background, creating a serene coastal scene."`<br/>
    /// (Note: `background.expandPrompt.mode` only affects `background.prompt`)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetBackgroundExpandPromptMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.auto")]
        AiAuto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.never")]
        AiNever,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetBackgroundExpandPromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetBackgroundExpandPromptMode value)
        {
            return value switch
            {
                EditImageGetBackgroundExpandPromptMode.AiAuto => "ai.auto",
                EditImageGetBackgroundExpandPromptMode.AiNever => "ai.never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetBackgroundExpandPromptMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.auto" => EditImageGetBackgroundExpandPromptMode.AiAuto,
                "ai.never" => EditImageGetBackgroundExpandPromptMode.AiNever,
                _ => null,
            };
        }
    }
}