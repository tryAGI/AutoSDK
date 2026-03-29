//HintName: G.Models.CreateEvalRunDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the run.<br/>
    /// Currently it is fixed to `eval`.<br/>
    /// Example: eval
    /// </summary>
    public enum CreateEvalRunDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalRunDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalRunDTOType value)
        {
            return value switch
            {
                CreateEvalRunDTOType.Eval => "eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalRunDTOType? ToEnum(string value)
        {
            return value switch
            {
                "eval" => CreateEvalRunDTOType.Eval,
                _ => null,
            };
        }
    }
}