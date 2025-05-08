//HintName: G.Models.CreateEvalResponsesRunDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run data source. Always `completions`.<br/>
    /// Default Value: completions
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalResponsesRunDataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completions")]
        Completions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalResponsesRunDataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalResponsesRunDataSourceType value)
        {
            return value switch
            {
                CreateEvalResponsesRunDataSourceType.Completions => "completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalResponsesRunDataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "completions" => CreateEvalResponsesRunDataSourceType.Completions,
                _ => null,
            };
        }
    }
}