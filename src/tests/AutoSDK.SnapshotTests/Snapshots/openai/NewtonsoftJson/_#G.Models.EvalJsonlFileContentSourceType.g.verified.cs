//HintName: G.Models.EvalJsonlFileContentSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of jsonl source. Always `file_content`.<br/>
    /// Default Value: file_content
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalJsonlFileContentSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_content")]
        FileContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalJsonlFileContentSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalJsonlFileContentSourceType value)
        {
            return value switch
            {
                EvalJsonlFileContentSourceType.FileContent => "file_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalJsonlFileContentSourceType? ToEnum(string value)
        {
            return value switch
            {
                "file_content" => EvalJsonlFileContentSourceType.FileContent,
                _ => null,
            };
        }
    }
}