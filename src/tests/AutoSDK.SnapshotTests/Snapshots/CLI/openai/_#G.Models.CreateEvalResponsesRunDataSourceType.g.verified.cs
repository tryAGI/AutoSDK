//HintName: G.Models.CreateEvalResponsesRunDataSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of run data source. Always `responses`.<br/>
    /// Default Value: responses
    /// </summary>
    public enum CreateEvalResponsesRunDataSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Responses,
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
                CreateEvalResponsesRunDataSourceType.Responses => "responses",
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
                "responses" => CreateEvalResponsesRunDataSourceType.Responses,
                _ => null,
            };
        }
    }
}