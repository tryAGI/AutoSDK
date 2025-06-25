//HintName: G.Models.ModelObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "model".
    /// </summary>
    public enum ModelObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelObject value)
        {
            return value switch
            {
                ModelObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelObject.Model,
                _ => null,
            };
        }
    }
}