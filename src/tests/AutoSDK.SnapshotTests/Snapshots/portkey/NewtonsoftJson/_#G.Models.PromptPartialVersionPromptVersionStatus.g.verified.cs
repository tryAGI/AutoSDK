//HintName: G.Models.PromptPartialVersionPromptVersionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptPartialVersionPromptVersionStatus
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
    public static class PromptPartialVersionPromptVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPartialVersionPromptVersionStatus value)
        {
            return value switch
            {
                PromptPartialVersionPromptVersionStatus.Active => "active",
                PromptPartialVersionPromptVersionStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPartialVersionPromptVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PromptPartialVersionPromptVersionStatus.Active,
                "archived" => PromptPartialVersionPromptVersionStatus.Archived,
                _ => null,
            };
        }
    }
}