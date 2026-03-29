//HintName: G.Models.InputModality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InputModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputModality value)
        {
            return value switch
            {
                InputModality.Audio => "audio",
                InputModality.File => "file",
                InputModality.Image => "image",
                InputModality.Text => "text",
                InputModality.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => InputModality.Audio,
                "file" => InputModality.File,
                "image" => InputModality.Image,
                "text" => InputModality.Text,
                "video" => InputModality.Video,
                _ => null,
            };
        }
    }
}