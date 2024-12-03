//HintName: G.Models.ChatRequestCitationQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to `"accurate"`.<br/>
    /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.<br/>
    /// Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestCitationQuality
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accurate")]
        Accurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestCitationQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestCitationQuality value)
        {
            return value switch
            {
                ChatRequestCitationQuality.Fast => "fast",
                ChatRequestCitationQuality.Accurate => "accurate",
                ChatRequestCitationQuality.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestCitationQuality? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ChatRequestCitationQuality.Fast,
                "accurate" => ChatRequestCitationQuality.Accurate,
                "off" => ChatRequestCitationQuality.Off,
                _ => null,
            };
        }
    }
}