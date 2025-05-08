//HintName: G.Models.CreateEvalJsonlRunDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `jsonl`.<br/>
    /// Default Value: jsonl
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalJsonlRunDataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jsonl")]
        Jsonl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalJsonlRunDataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalJsonlRunDataSourceType value)
        {
            return value switch
            {
                CreateEvalJsonlRunDataSourceType.Jsonl => "jsonl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalJsonlRunDataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => CreateEvalJsonlRunDataSourceType.Jsonl,
                _ => null,
            };
        }
    }
}