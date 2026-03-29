//HintName: G.Models.CreateTaskRequestVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        RefineModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant4Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant4Type.RefineModel => "refine_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "refine_model" => CreateTaskRequestVariant4Type.RefineModel,
                _ => null,
            };
        }
    }
}