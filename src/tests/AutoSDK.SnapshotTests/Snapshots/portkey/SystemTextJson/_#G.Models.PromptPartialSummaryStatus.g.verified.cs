//HintName: G.Models.PromptPartialSummaryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptPartialSummaryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptPartialSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPartialSummaryStatus value)
        {
            return value switch
            {
                PromptPartialSummaryStatus.Active => "active",
                PromptPartialSummaryStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPartialSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PromptPartialSummaryStatus.Active,
                "archived" => PromptPartialSummaryStatus.Archived,
                _ => null,
            };
        }
    }
}