//HintName: G.Models.ModelEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelEnum
    {
        /// <summary>
        /// Fast and cost-effective model
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-haiku-latest")]
        Claude35HaikuLatest,
        /// <summary>
        /// Fast and cost-effective model
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku-20241022")]
        Claude3Haiku20241022,
        /// <summary>
        /// Our most intelligent model
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-latest")]
        Claude35SonnetLatest,
        /// <summary>
        /// Our most intelligent model
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20241022")]
        Claude35Sonnet20241022,
        /// <summary>
        /// Our previous most intelligent model
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-20240620")]
        Claude35Sonnet20240620,
        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-opus-latest")]
        Claude3OpusLatest,
        /// <summary>
        /// Excels at writing and complex tasks
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-opus-20240229")]
        Claude3Opus20240229,
        /// <summary>
        /// Balance of speed and intelligence
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-sonnet-20240229")]
        Claude3Sonnet20240229,
        /// <summary>
        /// Our previous fast and cost-effective
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku-20240307")]
        Claude3Haiku20240307,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-2.1")]
        Claude21,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-2.0")]
        Claude20,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-instant-1.2")]
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