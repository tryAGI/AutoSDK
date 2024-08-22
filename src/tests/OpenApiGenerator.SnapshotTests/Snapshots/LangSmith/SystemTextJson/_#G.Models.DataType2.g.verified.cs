//HintName: G.Models.DataType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DataType2
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
    public static class DataType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataType2 value)
        {
            return value switch
            {
                DataType2.Kv => "kv",
                DataType2.Llm => "llm",
                DataType2.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataType2? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DataType2.Kv,
                "llm" => DataType2.Llm,
                "chat" => DataType2.Chat,
                _ => null,
            };
        }
    }
}