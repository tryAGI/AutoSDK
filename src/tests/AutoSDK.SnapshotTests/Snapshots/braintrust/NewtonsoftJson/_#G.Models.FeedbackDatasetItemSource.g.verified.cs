//HintName: G.Models.FeedbackDatasetItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source of the feedback. Must be one of "external" (default), "app", or "api"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackDatasetItemSource
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
    public static class FeedbackDatasetItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackDatasetItemSource value)
        {
            return value switch
            {
                FeedbackDatasetItemSource.Api => "api",
                FeedbackDatasetItemSource.App => "app",
                FeedbackDatasetItemSource.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackDatasetItemSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => FeedbackDatasetItemSource.Api,
                "app" => FeedbackDatasetItemSource.App,
                "external" => FeedbackDatasetItemSource.External,
                _ => null,
            };
        }
    }
}