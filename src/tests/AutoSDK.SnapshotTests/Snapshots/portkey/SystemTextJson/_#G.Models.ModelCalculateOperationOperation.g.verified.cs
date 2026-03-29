//HintName: G.Models.ModelCalculateOperationOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operation type
    /// </summary>
    public enum ModelCalculateOperationOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelCalculateOperationOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCalculateOperationOperation value)
        {
            return value switch
            {
                ModelCalculateOperationOperation.Multiply => "multiply",
                ModelCalculateOperationOperation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCalculateOperationOperation? ToEnum(string value)
        {
            return value switch
            {
                "multiply" => ModelCalculateOperationOperation.Multiply,
                "sum" => ModelCalculateOperationOperation.Sum,
                _ => null,
            };
        }
    }
}