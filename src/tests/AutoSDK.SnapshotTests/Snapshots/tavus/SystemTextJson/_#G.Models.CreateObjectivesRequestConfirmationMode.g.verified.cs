//HintName: G.Models.CreateObjectivesRequestConfirmationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateObjectivesRequestConfirmationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObjectivesRequestConfirmationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObjectivesRequestConfirmationMode value)
        {
            return value switch
            {
                CreateObjectivesRequestConfirmationMode.Auto => "auto",
                CreateObjectivesRequestConfirmationMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObjectivesRequestConfirmationMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateObjectivesRequestConfirmationMode.Auto,
                "manual" => CreateObjectivesRequestConfirmationMode.Manual,
                _ => null,
            };
        }
    }
}