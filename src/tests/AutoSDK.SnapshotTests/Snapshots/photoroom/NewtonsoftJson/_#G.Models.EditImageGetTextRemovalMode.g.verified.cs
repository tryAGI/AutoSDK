//HintName: G.Models.EditImageGetTextRemovalMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetTextRemovalMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.all")]
        AiAll,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.artificial")]
        AiArtificial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.natural")]
        AiNatural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetTextRemovalModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetTextRemovalMode value)
        {
            return value switch
            {
                EditImageGetTextRemovalMode.AiAll => "ai.all",
                EditImageGetTextRemovalMode.AiArtificial => "ai.artificial",
                EditImageGetTextRemovalMode.AiNatural => "ai.natural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetTextRemovalMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.all" => EditImageGetTextRemovalMode.AiAll,
                "ai.artificial" => EditImageGetTextRemovalMode.AiArtificial,
                "ai.natural" => EditImageGetTextRemovalMode.AiNatural,
                _ => null,
            };
        }
    }
}