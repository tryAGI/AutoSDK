﻿//HintName: G.Models.GetKnowledgeBaseURLResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKnowledgeBaseURLResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKnowledgeBaseURLResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKnowledgeBaseURLResponseModelType value)
        {
            return value switch
            {
                GetKnowledgeBaseURLResponseModelType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKnowledgeBaseURLResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "url" => GetKnowledgeBaseURLResponseModelType.Url,
                _ => null,
            };
        }
    }
}