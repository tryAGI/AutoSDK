//HintName: G.Models.ScoreSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATION")]
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API")]
        Api,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EVAL")]
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSource value)
        {
            return value switch
            {
                ScoreSource.Annotation => "ANNOTATION",
                ScoreSource.Api => "API",
                ScoreSource.Eval => "EVAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATION" => ScoreSource.Annotation,
                "API" => ScoreSource.Api,
                "EVAL" => ScoreSource.Eval,
                _ => null,
            };
        }
    }
}