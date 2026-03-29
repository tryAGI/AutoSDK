//HintName: G.Models.Prompt2025VersionPromptBodyToolChoiceFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Prompt2025VersionPromptBodyToolChoiceFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Prompt2025VersionPromptBodyToolChoiceFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Prompt2025VersionPromptBodyToolChoiceFunctionType value)
        {
            return value switch
            {
                Prompt2025VersionPromptBodyToolChoiceFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Prompt2025VersionPromptBodyToolChoiceFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => Prompt2025VersionPromptBodyToolChoiceFunctionType.Function,
                _ => null,
            };
        }
    }
}