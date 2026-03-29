//HintName: G.Models.Script.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Text script position.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Script
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="baseline")]
        Baseline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sub")]
        Sub,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="super")]
        Super,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScriptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Script value)
        {
            return value switch
            {
                Script.Baseline => "baseline",
                Script.Sub => "sub",
                Script.Super => "super",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Script? ToEnum(string value)
        {
            return value switch
            {
                "baseline" => Script.Baseline,
                "sub" => Script.Sub,
                "super" => Script.Super,
                _ => null,
            };
        }
    }
}