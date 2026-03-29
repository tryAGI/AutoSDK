//HintName: G.Models.CreateFunctionToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "function" for Function tool.
    /// </summary>
    public enum CreateFunctionToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFunctionToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFunctionToolDTOType value)
        {
            return value switch
            {
                CreateFunctionToolDTOType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFunctionToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "function" => CreateFunctionToolDTOType.Function,
                _ => null,
            };
        }
    }
}