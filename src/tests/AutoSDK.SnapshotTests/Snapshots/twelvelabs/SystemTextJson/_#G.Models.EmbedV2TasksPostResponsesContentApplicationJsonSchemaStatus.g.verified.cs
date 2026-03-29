//HintName: G.Models.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The initial status of the embedding task.
    /// </summary>
    public enum EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus value)
        {
            return value switch
            {
                EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus.Processing,
                _ => null,
            };
        }
    }
}