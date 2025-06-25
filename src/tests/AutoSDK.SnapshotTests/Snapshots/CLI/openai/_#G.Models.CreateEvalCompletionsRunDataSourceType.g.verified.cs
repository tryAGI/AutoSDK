//HintName: G.Models.CreateEvalCompletionsRunDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run data source. Always `completions`.<br/>
    /// Default Value: completions
    /// </summary>
    public enum CreateEvalCompletionsRunDataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Completions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalCompletionsRunDataSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalCompletionsRunDataSourceType value)
        {
            return value switch
            {
                CreateEvalCompletionsRunDataSourceType.Completions => "completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalCompletionsRunDataSourceType? ToEnum(string value)
        {
            return value switch
            {
                "completions" => CreateEvalCompletionsRunDataSourceType.Completions,
                _ => null,
            };
        }
    }
}