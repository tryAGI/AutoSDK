//HintName: G.Models.CreateSearchRequestIncludeAnswer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSearchRequestIncludeAnswer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced")]
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSearchRequestIncludeAnswerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestIncludeAnswer value)
        {
            return value switch
            {
                CreateSearchRequestIncludeAnswer.Advanced => "advanced",
                CreateSearchRequestIncludeAnswer.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestIncludeAnswer? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateSearchRequestIncludeAnswer.Advanced,
                "basic" => CreateSearchRequestIncludeAnswer.Basic,
                _ => null,
            };
        }
    }
}