//HintName: G.Models.ModelEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Claude35HaikuLatest,
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude35SonnetLatest,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet20240620,
        /// <summary>
        /// 
        /// </summary>
        Claude3OpusLatest,
        /// <summary>
        /// 
        /// </summary>
        Claude3Opus20240229,
        /// <summary>
        /// 
        /// </summary>
        Claude3Sonnet20240229,
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        Claude21,
        /// <summary>
        /// 
        /// </summary>
        Claude20,
        /// <summary>
        /// 
        /// </summary>
        ClaudeInstant12,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEnum value)
        {
            return value switch
            {
                ModelEnum.Claude35HaikuLatest => "claude-3-5-haiku-latest",
                ModelEnum.Claude3Haiku20241022 => "claude-3-haiku-20241022",
                ModelEnum.Claude35SonnetLatest => "claude-3-5-sonnet-latest",
                ModelEnum.Claude35Sonnet20241022 => "claude-3-5-sonnet-20241022",
                ModelEnum.Claude35Sonnet20240620 => "claude-3-5-sonnet-20240620",
                ModelEnum.Claude3OpusLatest => "claude-3-opus-latest",
                ModelEnum.Claude3Opus20240229 => "claude-3-opus-20240229",
                ModelEnum.Claude3Sonnet20240229 => "claude-3-sonnet-20240229",
                ModelEnum.Claude3Haiku20240307 => "claude-3-haiku-20240307",
                ModelEnum.Claude21 => "claude-2.1",
                ModelEnum.Claude20 => "claude-2.0",
                ModelEnum.ClaudeInstant12 => "claude-instant-1.2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-haiku-latest" => ModelEnum.Claude35HaikuLatest,
                "claude-3-haiku-20241022" => ModelEnum.Claude3Haiku20241022,
                "claude-3-5-sonnet-latest" => ModelEnum.Claude35SonnetLatest,
                "claude-3-5-sonnet-20241022" => ModelEnum.Claude35Sonnet20241022,
                "claude-3-5-sonnet-20240620" => ModelEnum.Claude35Sonnet20240620,
                "claude-3-opus-latest" => ModelEnum.Claude3OpusLatest,
                "claude-3-opus-20240229" => ModelEnum.Claude3Opus20240229,
                "claude-3-sonnet-20240229" => ModelEnum.Claude3Sonnet20240229,
                "claude-3-haiku-20240307" => ModelEnum.Claude3Haiku20240307,
                "claude-2.1" => ModelEnum.Claude21,
                "claude-2.0" => ModelEnum.Claude20,
                "claude-instant-1.2" => ModelEnum.ClaudeInstant12,
                _ => null,
            };
        }
    }
}