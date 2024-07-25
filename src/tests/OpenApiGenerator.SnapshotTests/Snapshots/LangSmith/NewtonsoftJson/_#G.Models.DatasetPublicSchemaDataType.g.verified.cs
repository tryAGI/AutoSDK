//HintName: G.Models.DatasetPublicSchemaDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetPublicSchemaDataType
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
    public static class DatasetPublicSchemaDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetPublicSchemaDataType value)
        {
            return value switch
            {
                DatasetPublicSchemaDataType.Kv => "kv",
                DatasetPublicSchemaDataType.Llm => "llm",
                DatasetPublicSchemaDataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetPublicSchemaDataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DatasetPublicSchemaDataType.Kv,
                "llm" => DatasetPublicSchemaDataType.Llm,
                "chat" => DatasetPublicSchemaDataType.Chat,
                _ => null,
            };
        }
    }
}