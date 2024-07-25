//HintName: G.Models.DatasetDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DatasetDataType
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
    public static class DatasetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetDataType value)
        {
            return value switch
            {
                DatasetDataType.Kv => "kv",
                DatasetDataType.Llm => "llm",
                DatasetDataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetDataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DatasetDataType.Kv,
                "llm" => DatasetDataType.Llm,
                "chat" => DatasetDataType.Chat,
                _ => null,
            };
        }
    }
}