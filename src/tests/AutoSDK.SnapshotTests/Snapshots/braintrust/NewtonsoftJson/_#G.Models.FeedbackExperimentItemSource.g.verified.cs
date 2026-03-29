//HintName: G.Models.FeedbackExperimentItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the feedback. Must be one of "external" (default), "app", or "api"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackExperimentItemSource
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
    public static class FeedbackExperimentItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackExperimentItemSource value)
        {
            return value switch
            {
                FeedbackExperimentItemSource.Api => "api",
                FeedbackExperimentItemSource.App => "app",
                FeedbackExperimentItemSource.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackExperimentItemSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackExperimentItemSource.Api,
                "app" => FeedbackExperimentItemSource.App,
                "external" => FeedbackExperimentItemSource.External,
                _ => null,
            };
        }
    }
}