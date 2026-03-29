//HintName: G.Models.CreateTaskRequestVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        MultiviewToModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant3Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant3Type.MultiviewToModel => "multiview_to_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "multiview_to_model" => CreateTaskRequestVariant3Type.MultiviewToModel,
                _ => null,
            };
        }
    }
}