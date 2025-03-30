//HintName: G.Models.GetKnowledgeBaseFileResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetKnowledgeBaseFileResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseFileResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseFileResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseFileResponseModelType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseFileResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "file" => GetKnowledgeBaseFileResponseModelType.File,
                _ => null,
            };
        }
    }
}