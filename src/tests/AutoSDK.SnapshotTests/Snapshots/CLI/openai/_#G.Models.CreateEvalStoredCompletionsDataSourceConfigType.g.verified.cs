//HintName: G.Models.CreateEvalStoredCompletionsDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `stored_completions`.<br/>
    /// Default Value: stored_completions
    /// </summary>
    public enum CreateEvalStoredCompletionsDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        StoredCompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalStoredCompletionsDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalStoredCompletionsDataSourceConfigType value)
        {
            return value switch
            {
                CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions => "stored_completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalStoredCompletionsDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "stored_completions" => CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions,
                _ => null,
            };
        }
    }
}