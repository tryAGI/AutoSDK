//HintName: G.Models.PromptPartialStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptPartialStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptPartialStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPartialStatus value)
        {
            return value switch
            {
                PromptPartialStatus.Active => "active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPartialStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PromptPartialStatus.Active,
                _ => null,
            };
        }
    }
}