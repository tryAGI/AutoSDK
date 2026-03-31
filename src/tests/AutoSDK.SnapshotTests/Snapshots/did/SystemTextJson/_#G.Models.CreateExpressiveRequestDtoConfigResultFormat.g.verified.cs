//HintName: G.Models.CreateExpressiveRequestDtoConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file format of the result. If result_url is provided, result_format must match the format of the result_url.<br/>
    /// Example: mp4
    /// </summary>
    public enum CreateExpressiveRequestDtoConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoConfigResultFormat value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoConfigResultFormat.Mov => "mov",
                CreateExpressiveRequestDtoConfigResultFormat.Mp4 => "mp4",
                CreateExpressiveRequestDtoConfigResultFormat.Webm => "webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateExpressiveRequestDtoConfigResultFormat.Mov,
                "mp4" => CreateExpressiveRequestDtoConfigResultFormat.Mp4,
                "webm" => CreateExpressiveRequestDtoConfigResultFormat.Webm,
                _ => null,
            };
        }
    }
}