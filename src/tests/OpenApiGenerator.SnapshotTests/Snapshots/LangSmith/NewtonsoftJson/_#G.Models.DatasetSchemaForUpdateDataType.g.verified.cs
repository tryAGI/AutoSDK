//HintName: G.Models.DatasetSchemaForUpdateDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetSchemaForUpdateDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kv")]
        Kv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
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