//HintName: G.Models.DatasetSchemaForUpdateDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DatasetSchemaForUpdateDataType
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
    public static class DatasetSchemaForUpdateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetSchemaForUpdateDataType value)
        {
            return value switch
            {
                DatasetSchemaForUpdateDataType.Kv => "kv",
                DatasetSchemaForUpdateDataType.Llm => "llm",
                DatasetSchemaForUpdateDataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetSchemaForUpdateDataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DatasetSchemaForUpdateDataType.Kv,
                "llm" => DatasetSchemaForUpdateDataType.Llm,
                "chat" => DatasetSchemaForUpdateDataType.Chat,
                _ => null,
            };
        }
    }
}