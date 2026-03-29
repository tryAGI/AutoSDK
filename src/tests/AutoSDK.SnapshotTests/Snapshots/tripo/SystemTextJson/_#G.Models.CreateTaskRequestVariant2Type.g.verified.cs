//HintName: G.Models.CreateTaskRequestVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ImageToModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant2Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant2Type.ImageToModel => "image_to_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "image_to_model" => CreateTaskRequestVariant2Type.ImageToModel,
                _ => null,
            };
        }
    }
}