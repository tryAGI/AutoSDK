//HintName: G.Models.FeedbackProjectLogsItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the feedback. Must be one of "external" (default), "app", or "api"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackProjectLogsItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api")]
        Api,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="app")]
        App,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external")]
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackProjectLogsItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackProjectLogsItemSource value)
        {
            return value switch
            {
                FeedbackProjectLogsItemSource.Api => "api",
                FeedbackProjectLogsItemSource.App => "app",
                FeedbackProjectLogsItemSource.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackProjectLogsItemSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackProjectLogsItemSource.Api,
                "app" => FeedbackProjectLogsItemSource.App,
                "external" => FeedbackProjectLogsItemSource.External,
                _ => null,
            };
        }
    }
}