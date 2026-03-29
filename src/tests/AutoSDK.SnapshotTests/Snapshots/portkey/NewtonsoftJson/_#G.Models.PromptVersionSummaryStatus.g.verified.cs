//HintName: G.Models.PromptVersionSummaryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionSummaryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archived")]
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionSummaryStatus value)
        {
            return value switch
            {
                PromptVersionSummaryStatus.Active => "active",
                PromptVersionSummaryStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PromptVersionSummaryStatus.Active,
                "archived" => PromptVersionSummaryStatus.Archived,
                _ => null,
            };
        }
    }
}