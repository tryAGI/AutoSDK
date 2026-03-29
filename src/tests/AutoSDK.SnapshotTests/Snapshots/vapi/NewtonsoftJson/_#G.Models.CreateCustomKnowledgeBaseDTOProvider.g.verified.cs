//HintName: G.Models.CreateCustomKnowledgeBaseDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This knowledge base is bring your own knowledge base implementation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCustomKnowledgeBaseDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-knowledge-base")]
        CustomKnowledgeBase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCustomKnowledgeBaseDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomKnowledgeBaseDTOProvider value)
        {
            return value switch
            {
                CreateCustomKnowledgeBaseDTOProvider.CustomKnowledgeBase => "custom-knowledge-base",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomKnowledgeBaseDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-knowledge-base" => CreateCustomKnowledgeBaseDTOProvider.CustomKnowledgeBase,
                _ => null,
            };
        }
    }
}