//HintName: G.Models.CommentObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CommentObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OBSERVATION")]
        Observation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROMPT")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SESSION")]
        Session,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRACE")]
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommentObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentObjectType value)
        {
            return value switch
            {
                CommentObjectType.Observation => "OBSERVATION",
                CommentObjectType.Prompt => "PROMPT",
                CommentObjectType.Session => "SESSION",
                CommentObjectType.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentObjectType? ToEnum(string value)
        {
            return value switch
            {
                "OBSERVATION" => CommentObjectType.Observation,
                "PROMPT" => CommentObjectType.Prompt,
                "SESSION" => CommentObjectType.Session,
                "TRACE" => CommentObjectType.Trace,
                _ => null,
            };
        }
    }
}