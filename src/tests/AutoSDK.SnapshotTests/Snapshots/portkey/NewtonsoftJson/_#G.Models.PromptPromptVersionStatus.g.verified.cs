//HintName: G.Models.PromptPromptVersionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptPromptVersionStatus
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
    public static class PromptPromptVersionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPromptVersionStatus value)
        {
            return value switch
            {
                PromptPromptVersionStatus.Active => "active",
                PromptPromptVersionStatus.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPromptVersionStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => PromptPromptVersionStatus.Active,
                "archived" => PromptPromptVersionStatus.Archived,
                _ => null,
            };
        }
    }
}