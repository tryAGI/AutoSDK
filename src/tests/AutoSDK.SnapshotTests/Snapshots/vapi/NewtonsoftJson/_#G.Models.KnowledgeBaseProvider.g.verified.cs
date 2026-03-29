//HintName: G.Models.KnowledgeBaseProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the knowledge base<br/>
    /// Example: google
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KnowledgeBaseProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseProvider value)
        {
            return value switch
            {
                KnowledgeBaseProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => KnowledgeBaseProvider.Google,
                _ => null,
            };
        }
    }
}