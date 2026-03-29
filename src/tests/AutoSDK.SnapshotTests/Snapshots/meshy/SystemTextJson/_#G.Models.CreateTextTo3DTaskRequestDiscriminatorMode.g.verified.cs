//HintName: G.Models.CreateTextTo3DTaskRequestDiscriminatorMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTextTo3DTaskRequestDiscriminatorMode
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Refine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextTo3DTaskRequestDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextTo3DTaskRequestDiscriminatorMode value)
        {
            return value switch
            {
                CreateTextTo3DTaskRequestDiscriminatorMode.Preview => "preview",
                CreateTextTo3DTaskRequestDiscriminatorMode.Refine => "refine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextTo3DTaskRequestDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateTextTo3DTaskRequestDiscriminatorMode.Preview,
                "refine" => CreateTextTo3DTaskRequestDiscriminatorMode.Refine,
                _ => null,
            };
        }
    }
}