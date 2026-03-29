//HintName: G.Models.CreateTaskRequestVariant9Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant9Type
    {
        /// <summary>
        /// 
        /// </summary>
        ConvertModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant9Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant9Type.ConvertModel => "convert_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "convert_model" => CreateTaskRequestVariant9Type.ConvertModel,
                _ => null,
            };
        }
    }
}