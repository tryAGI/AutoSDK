//HintName: G.Models.ConvAIWorkspaceStoredSecretConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConvAIWorkspaceStoredSecretConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stored")]
        Stored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConvAIWorkspaceStoredSecretConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConvAIWorkspaceStoredSecretConfigType value)
        {
            return value switch
            {
                ConvAIWorkspaceStoredSecretConfigType.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConvAIWorkspaceStoredSecretConfigType? ToEnum(string value)
        {
            return value switch
            {
                "stored" => ConvAIWorkspaceStoredSecretConfigType.Stored,
                _ => null,
            };
        }
    }
}