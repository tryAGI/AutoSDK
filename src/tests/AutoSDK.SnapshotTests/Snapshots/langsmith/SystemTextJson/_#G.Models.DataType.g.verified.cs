//HintName: G.Models.DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Kv,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataType value)
        {
            return value switch
            {
                DataType.Kv => "kv",
                DataType.Llm => "llm",
                DataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DataType.Kv,
                "llm" => DataType.Llm,
                "chat" => DataType.Chat,
                _ => null,
            };
        }
    }
}