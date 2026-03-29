//HintName: G.Models.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcription")]
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="visual")]
        Visual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="visual-text")]
        VisualText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems value)
        {
            return value switch
            {
                EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Audio => "audio",
                EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Transcription => "transcription",
                EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Visual => "visual",
                EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.VisualText => "visual-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Audio,
                "transcription" => EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Transcription,
                "visual" => EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.Visual,
                "visual-text" => EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems.VisualText,
                _ => null,
            };
        }
    }
}