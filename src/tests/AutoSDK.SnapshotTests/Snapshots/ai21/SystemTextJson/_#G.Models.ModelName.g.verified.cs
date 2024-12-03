//HintName: G.Models.ModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum ModelName
    {
        /// <summary>
        /// 
        /// </summary>
        JambaInstruct,
        /// <summary>
        /// 
        /// </summary>
        JambaInstructPreview,
        /// <summary>
        /// 
        /// </summary>
        Jamba15Mini,
        /// <summary>
        /// 
        /// </summary>
        Jamba15Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelName value)
        {
            return value switch
            {
                ModelName.JambaInstruct => "jamba-instruct",
                ModelName.JambaInstructPreview => "jamba-instruct-preview",
                ModelName.Jamba15Mini => "jamba-1.5-mini",
                ModelName.Jamba15Large => "jamba-1.5-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelName? ToEnum(string value)
        {
            return value switch
            {
                "jamba-instruct" => ModelName.JambaInstruct,
                "jamba-instruct-preview" => ModelName.JambaInstructPreview,
                "jamba-1.5-mini" => ModelName.Jamba15Mini,
                "jamba-1.5-large" => ModelName.Jamba15Large,
                _ => null,
            };
        }
    }
}