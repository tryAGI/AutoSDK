//HintName: G.Models.FallbackAssemblyAITranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackAssemblyAITranscriberProvider
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
    public static class FallbackAssemblyAITranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAssemblyAITranscriberProvider value)
        {
            return value switch
            {
                FallbackAssemblyAITranscriberProvider.AssemblyAi => "assembly-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAssemblyAITranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "assembly-ai" => FallbackAssemblyAITranscriberProvider.AssemblyAi,
                _ => null,
            };
        }
    }
}