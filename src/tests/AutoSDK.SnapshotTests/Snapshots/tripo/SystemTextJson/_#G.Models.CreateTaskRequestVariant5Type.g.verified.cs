//HintName: G.Models.CreateTaskRequestVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        AnimatePrerigcheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant5Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant5Type.AnimatePrerigcheck => "animate_prerigcheck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "animate_prerigcheck" => CreateTaskRequestVariant5Type.AnimatePrerigcheck,
                _ => null,
            };
        }
    }
}