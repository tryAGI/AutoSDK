//HintName: G.Models.GuardrailSummaryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the guardrail
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GuardrailSummaryStatus
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