//HintName: G.Models.TaskType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        Convert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskType value)
        {
            return value switch
            {
                TaskType.Chunk => "chunk",
                TaskType.Convert => "convert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TaskType.Chunk,
                "convert" => TaskType.Convert,
                _ => null,
            };
        }
    }
}