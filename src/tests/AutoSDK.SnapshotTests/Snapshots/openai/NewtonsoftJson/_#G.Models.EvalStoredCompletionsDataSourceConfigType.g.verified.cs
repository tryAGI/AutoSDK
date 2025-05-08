//HintName: G.Models.EvalStoredCompletionsDataSourceConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of data source. Always `stored_completions`.<br/>
    /// Default Value: stored_completions
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalStoredCompletionsDataSourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stored_completions")]
        StoredCompletions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalStoredCompletionsDataSourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalStoredCompletionsDataSourceConfigType value)
        {
            return value switch
            {
                EvalStoredCompletionsDataSourceConfigType.StoredCompletions => "stored_completions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalStoredCompletionsDataSourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "stored_completions" => EvalStoredCompletionsDataSourceConfigType.StoredCompletions,
                _ => null,
            };
        }
    }
}