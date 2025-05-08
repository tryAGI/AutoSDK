//HintName: G.Models.EvalJsonlFileIdSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of jsonl source. Always `file_id`.<br/>
    /// Default Value: file_id
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalJsonlFileIdSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_id")]
        FileId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalJsonlFileIdSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalJsonlFileIdSourceType value)
        {
            return value switch
            {
                EvalJsonlFileIdSourceType.FileId => "file_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalJsonlFileIdSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file_id" => EvalJsonlFileIdSourceType.FileId,
                _ => null,
            };
        }
    }
}