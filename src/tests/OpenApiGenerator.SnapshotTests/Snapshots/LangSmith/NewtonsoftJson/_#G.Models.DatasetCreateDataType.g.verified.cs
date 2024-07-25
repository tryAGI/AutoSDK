//HintName: G.Models.DatasetCreateDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DatasetCreateDataType
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
    public static class DatasetCreateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetCreateDataType value)
        {
            return value switch
            {
                DatasetCreateDataType.Kv => "kv",
                DatasetCreateDataType.Llm => "llm",
                DatasetCreateDataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetCreateDataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => DatasetCreateDataType.Kv,
                "llm" => DatasetCreateDataType.Llm,
                "chat" => DatasetCreateDataType.Chat,
                _ => null,
            };
        }
    }
}