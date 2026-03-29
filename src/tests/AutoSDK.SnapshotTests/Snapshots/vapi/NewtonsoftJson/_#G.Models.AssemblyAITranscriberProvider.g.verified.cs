//HintName: G.Models.AssemblyAITranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssemblyAITranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assembly-ai")]
        AssemblyAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssemblyAITranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberProvider value)
        {
            return value switch
            {
                AssemblyAITranscriberProvider.AssemblyAi => "assembly-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "assembly-ai" => AssemblyAITranscriberProvider.AssemblyAi,
                _ => null,
            };
        }
    }
}