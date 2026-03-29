//HintName: G.Models.GuardrailSummaryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the guardrail
    /// </summary>
    public enum GuardrailSummaryStatus
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
    public static class GuardrailSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailSummaryStatus value)
        {
            return value switch
            {
                GuardrailSummaryStatus.Active => "active",
                GuardrailSummaryStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GuardrailSummaryStatus.Active,
                "archived" => GuardrailSummaryStatus.Archived,
                _ => null,
            };
        }
    }
}