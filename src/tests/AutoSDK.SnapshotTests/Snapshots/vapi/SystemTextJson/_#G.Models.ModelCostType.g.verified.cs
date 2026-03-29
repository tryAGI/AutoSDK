//HintName: G.Models.ModelCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'model' for this class.
    /// </summary>
    public enum ModelCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCostType value)
        {
            return value switch
            {
                ModelCostType.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCostType? ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelCostType.Model,
                _ => null,
            };
        }
    }
}