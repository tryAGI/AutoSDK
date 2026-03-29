//HintName: G.Models.CreateSmallestAICredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSmallestAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="smallest-ai")]
        SmallestAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSmallestAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSmallestAICredentialDTOProvider value)
        {
            return value switch
            {
                CreateSmallestAICredentialDTOProvider.SmallestAi => "smallest-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSmallestAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "smallest-ai" => CreateSmallestAICredentialDTOProvider.SmallestAi,
                _ => null,
            };
        }
    }
}