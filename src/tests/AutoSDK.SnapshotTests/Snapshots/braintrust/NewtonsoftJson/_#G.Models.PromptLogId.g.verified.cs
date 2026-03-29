//HintName: G.Models.PromptLogId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A literal 'p' which identifies the object as a project prompt
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptLogId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p")]
        P,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptLogIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptLogId value)
        {
            return value switch
            {
                PromptLogId.P => "p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptLogId? ToEnum(string value)
        {
            return value switch
            {
                "p" => PromptLogId.P,
                _ => null,
            };
        }
    }
}